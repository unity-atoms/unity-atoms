using System.Collections;
using UnityEngine;
using UnityEngine.Assertions;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Manager responsible of spawning enmeies and keep track of which enemy wave we are currently facing.
    /// </summary>
    public class EnemyWaveManager : MonoBehaviour
    {
        [SerializeField]
        private Transform _player;

        [SerializeField]
        private GameObject _enemyPrefab;

        [SerializeField]
        private GameObjectValueList _spawnedEnemies;

        [SerializeField]
        private AtomReference<int> _waveCount = new AtomReference<int>(0);

        void Awake()
        {
            Assert.IsNotNull(_player);
            Assert.IsNotNull(_enemyPrefab);
            Assert.IsNotNull(_spawnedEnemies);
            Assert.IsNotNull(_waveCount);
        }

        private Coroutine _waveRoutine;

        IEnumerator StartWaves()
        {
            yield return new WaitForSeconds(3);

            for (var i = 0; i < _waveCount.Value; ++i)
            {
                if (_player != null)
                {
                    var randomMagnitude = 5f;
                    var randomPosAroundPlayer = new Vector3(
                        Random.Range(_player.transform.position.x - randomMagnitude, _player.transform.position.x + randomMagnitude),
                        Random.Range(_player.transform.position.y - randomMagnitude, _player.transform.position.y + randomMagnitude),
                        0f
                    );
                    var enemy = Instantiate(_enemyPrefab, randomPosAroundPlayer, Quaternion.identity);
                }
                yield return new WaitForSeconds(0.1f);
            }
        }

        public void StartWaveIfNoEnemiesLeft(GameObject enemyToRemove)
        {
            if (_spawnedEnemies.Count <= 0)
            {
                _waveCount.Value++;
                if (_waveRoutine != null)
                {
                    StopCoroutine(_waveRoutine);
                }
                _waveRoutine = StartCoroutine(StartWaves());
            }
        }

        public void StartWavesIfInGame(string gameState)
        {
            if (gameState == "InGame")
            {
                _waveCount.Value = 1;
                if (_waveRoutine != null)
                {
                    StopCoroutine(_waveRoutine);
                }
                _waveRoutine = StartCoroutine(StartWaves());
            }
        }
    }
}
