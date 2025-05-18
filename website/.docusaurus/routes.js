import React from 'react';
import ComponentCreator from '@docusaurus/ComponentCreator';

export default [
  {
    path: '/unity-atoms/__docusaurus/debug',
    component: ComponentCreator('/unity-atoms/__docusaurus/debug', '78e'),
    exact: true
  },
  {
    path: '/unity-atoms/__docusaurus/debug/config',
    component: ComponentCreator('/unity-atoms/__docusaurus/debug/config', '421'),
    exact: true
  },
  {
    path: '/unity-atoms/__docusaurus/debug/content',
    component: ComponentCreator('/unity-atoms/__docusaurus/debug/content', 'b89'),
    exact: true
  },
  {
    path: '/unity-atoms/__docusaurus/debug/globalData',
    component: ComponentCreator('/unity-atoms/__docusaurus/debug/globalData', 'c0c'),
    exact: true
  },
  {
    path: '/unity-atoms/__docusaurus/debug/metadata',
    component: ComponentCreator('/unity-atoms/__docusaurus/debug/metadata', '8a1'),
    exact: true
  },
  {
    path: '/unity-atoms/__docusaurus/debug/registry',
    component: ComponentCreator('/unity-atoms/__docusaurus/debug/registry', '256'),
    exact: true
  },
  {
    path: '/unity-atoms/__docusaurus/debug/routes',
    component: ComponentCreator('/unity-atoms/__docusaurus/debug/routes', 'f01'),
    exact: true
  },
  {
    path: '/unity-atoms/docs',
    component: ComponentCreator('/unity-atoms/docs', '85f'),
    routes: [
      {
        path: '/unity-atoms/docs',
        component: ComponentCreator('/unity-atoms/docs', '0cc'),
        routes: [
          {
            path: '/unity-atoms/docs',
            component: ComponentCreator('/unity-atoms/docs', 'd96'),
            routes: [
              {
                path: '/unity-atoms/docs/',
                component: ComponentCreator('/unity-atoms/docs/', '52f'),
                exact: true
              },
              {
                path: '/unity-atoms/docs/introduction/faq',
                component: ComponentCreator('/unity-atoms/docs/introduction/faq', 'd78'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/introduction/installation',
                component: ComponentCreator('/unity-atoms/docs/introduction/installation', '7f3'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/introduction/overview',
                component: ComponentCreator('/unity-atoms/docs/introduction/overview', '0a1'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/introduction/philosophy',
                component: ComponentCreator('/unity-atoms/docs/introduction/philosophy', '68b'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/introduction/preferences',
                component: ComponentCreator('/unity-atoms/docs/introduction/preferences', '00d'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/base-atoms',
                component: ComponentCreator('/unity-atoms/docs/subpackages/base-atoms', '679'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/fsm',
                component: ComponentCreator('/unity-atoms/docs/subpackages/fsm', 'd71'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/input-system',
                component: ComponentCreator('/unity-atoms/docs/subpackages/input-system', 'd09'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/mobile',
                component: ComponentCreator('/unity-atoms/docs/subpackages/mobile', '685'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/mono-hooks',
                component: ComponentCreator('/unity-atoms/docs/subpackages/mono-hooks', '0e1'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/scene-mgmt',
                component: ComponentCreator('/unity-atoms/docs/subpackages/scene-mgmt', '20f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/tags',
                component: ComponentCreator('/unity-atoms/docs/subpackages/tags', '03f'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/subpackages/ui',
                component: ComponentCreator('/unity-atoms/docs/subpackages/ui', 'b8d'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/actions',
                component: ComponentCreator('/unity-atoms/docs/tutorials/actions', 'fa3'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/advanced-example',
                component: ComponentCreator('/unity-atoms/docs/tutorials/advanced-example', '950'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/conditions',
                component: ComponentCreator('/unity-atoms/docs/tutorials/conditions', '59d'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/creating-atoms',
                component: ComponentCreator('/unity-atoms/docs/tutorials/creating-atoms', '9df'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/event-instancer',
                component: ComponentCreator('/unity-atoms/docs/tutorials/event-instancer', '86b'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/events',
                component: ComponentCreator('/unity-atoms/docs/tutorials/events', '48b'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/generator',
                component: ComponentCreator('/unity-atoms/docs/tutorials/generator', '4e5'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/listeners',
                component: ComponentCreator('/unity-atoms/docs/tutorials/listeners', '9f9'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/mono-hooks',
                component: ComponentCreator('/unity-atoms/docs/tutorials/mono-hooks', '703'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/unirx',
                component: ComponentCreator('/unity-atoms/docs/tutorials/unirx', '912'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/variable-instancer',
                component: ComponentCreator('/unity-atoms/docs/tutorials/variable-instancer', '4ce'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/variable-transformers',
                component: ComponentCreator('/unity-atoms/docs/tutorials/variable-transformers', 'b66'),
                exact: true,
                sidebar: "docs"
              },
              {
                path: '/unity-atoms/docs/tutorials/variables',
                component: ComponentCreator('/unity-atoms/docs/tutorials/variables', '13d'),
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
