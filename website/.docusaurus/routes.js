import React from 'react';
import ComponentCreator from '@docusaurus/ComponentCreator';

export default [
  {
    path: '/unity-atoms/docs',
    component: ComponentCreator('/unity-atoms/docs', '29f'),
    routes: [
      {
        path: '/unity-atoms/docs',
        component: ComponentCreator('/unity-atoms/docs', 'f6c'),
        routes: [
          {
            path: '/unity-atoms/docs',
            component: ComponentCreator('/unity-atoms/docs', '646'),
            routes: [
              {
                path: '/unity-atoms/docs/',
                component: ComponentCreator('/unity-atoms/docs/', '49f'),
                exact: true
              },
              {
                path: '/unity-atoms/docs/introduction/faq',
                component: ComponentCreator('/unity-atoms/docs/introduction/faq', '961'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/introduction/installation',
                component: ComponentCreator('/unity-atoms/docs/introduction/installation', '5c2'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/introduction/overview',
                component: ComponentCreator('/unity-atoms/docs/introduction/overview', '843'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/introduction/philosophy',
                component: ComponentCreator('/unity-atoms/docs/introduction/philosophy', '8c9'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/introduction/preferences',
                component: ComponentCreator('/unity-atoms/docs/introduction/preferences', 'c20'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/base-atoms',
                component: ComponentCreator('/unity-atoms/docs/subpackages/base-atoms', 'a1d'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/fsm',
                component: ComponentCreator('/unity-atoms/docs/subpackages/fsm', 'c85'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/input-system',
                component: ComponentCreator('/unity-atoms/docs/subpackages/input-system', '96f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/mobile',
                component: ComponentCreator('/unity-atoms/docs/subpackages/mobile', '59f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/mono-hooks',
                component: ComponentCreator('/unity-atoms/docs/subpackages/mono-hooks', '677'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/scene-mgmt',
                component: ComponentCreator('/unity-atoms/docs/subpackages/scene-mgmt', '570'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/tags',
                component: ComponentCreator('/unity-atoms/docs/subpackages/tags', '882'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/ui',
                component: ComponentCreator('/unity-atoms/docs/subpackages/ui', '086'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/actions',
                component: ComponentCreator('/unity-atoms/docs/tutorials/actions', '2fd'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/advanced-example',
                component: ComponentCreator('/unity-atoms/docs/tutorials/advanced-example', 'd0b'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/conditions',
                component: ComponentCreator('/unity-atoms/docs/tutorials/conditions', '7af'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/creating-atoms',
                component: ComponentCreator('/unity-atoms/docs/tutorials/creating-atoms', '225'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/event-instancer',
                component: ComponentCreator('/unity-atoms/docs/tutorials/event-instancer', 'e6e'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/events',
                component: ComponentCreator('/unity-atoms/docs/tutorials/events', '96d'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/generator',
                component: ComponentCreator('/unity-atoms/docs/tutorials/generator', '39f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/listeners',
                component: ComponentCreator('/unity-atoms/docs/tutorials/listeners', 'd52'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/mono-hooks',
                component: ComponentCreator('/unity-atoms/docs/tutorials/mono-hooks', '074'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/unirx',
                component: ComponentCreator('/unity-atoms/docs/tutorials/unirx', '73b'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/variable-instancer',
                component: ComponentCreator('/unity-atoms/docs/tutorials/variable-instancer', 'f0f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/variable-transformers',
                component: ComponentCreator('/unity-atoms/docs/tutorials/variable-transformers', '5bf'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/variables',
                component: ComponentCreator('/unity-atoms/docs/tutorials/variables', 'b3c'),
                exact: true,
                sidebar: "docs"
              }
            ]
          }
        ]
      }
    ]
  },
  {
    path: '/unity-atoms/',
    component: ComponentCreator('/unity-atoms/', '048'),
    exact: true
  },
  {
    path: '*',
    component: ComponentCreator('*'),
  },
];
