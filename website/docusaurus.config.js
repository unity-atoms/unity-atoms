module.exports={
  "title": "Unity Atoms",
  "tagline": "Tiny modular pieces utilizing the power of Scriptable Objects",
  "url": "https://unity-atoms.github.io",
  "baseUrl": "/unity-atoms/",
  "organizationName": "unity-atoms",
  "projectName": "unity-atoms",
  "scripts": [
    "https://buttons.github.io/buttons.js",
    "https://cdnjs.cloudflare.com/ajax/libs/clipboard.js/2.0.0/clipboard.min.js",
    "/unity-atoms/js/code-block-buttons.js"
  ],
  "stylesheets": [
    "/unity-atoms/css/code-block-buttons.css"
  ],
  "favicon": "img/favicon.ico",
  "customFields": {
    "docsUrl": "",
    "repoUrl": "https://github.com/unity-atoms/unity-atoms"
  },
  "onBrokenLinks": "log",
  "onBrokenMarkdownLinks": "log",
  "presets": [
    [
      "@docusaurus/preset-classic",
      {
        "docs": {
          "showLastUpdateAuthor": true,
          "showLastUpdateTime": true,
          "path": "../docs",
          "sidebarPath": "./sidebars.json"
        },
        "blog": {},
        "theme": {
          "customCss": "./src/css/customTheme.css"
        }
      }
    ]
  ],
  "plugins": [require.resolve("@cmfcmf/docusaurus-search-local")],
  "themeConfig": {
    "navbar": {
      "title": "Unity Atoms",
      "logo": {
        "src": "img/atoms-logo.svg"
      },
      "items": [
        {
          "to": "docs/introduction/installation",
          "label": "Installation",
          "position": "left"
        },
        {
          "to": "docs/tutorials/creating-atoms",
          "label": "Tutorials",
          "position": "left"
        },
        {
          "href": "https://www.github.com/unity-atoms/unity-atoms",
          "label": "Github",
          "position": "left"
        }
      ]
    },
    "image": "img/undraw_online.svg",
    "footer": {
      "links": [
        {
          title: 'Docs',
          items: [
            {
              label: 'Installation',
              to: 'docs/introduction/installation',
            },
            {
              label: 'Tutorials',
              to: 'docs/tutorials/creating-atoms',
            },
            {
              label: 'Subpackages',
              to: 'docs/subpackages/base-atoms',
            }
          ],
        },
        {
          title: 'Community',
          items: [
            {
              label: 'Discord',
              href: 'https://discord.gg/W4yd7E7',
            }
          ],
        },
        {
          title: 'More',
          items: [
            {
              label: 'Blog',
              href: 'https://medium.com/@adamramberg',
            },
            {
              label: 'GitHub',
              href: 'https://github.com/unity-atoms/unity-atoms',
            },
            {
              html: `<a
              className="github-button"
              href={repoUrl}
              data-icon="octicon-star"
              data-count-href="/AdamRamberg/unity-atoms/stargazers"
              data-show-count="true"
              data-count-aria-label="# stargazers on GitHub"
              aria-label="Star this project on GitHub"
            >`
            }
      ],
      "copyright": "Copyright © 2025 Adam Ramberg",
      "logo": {
        "src": "img/atoms-logo.svg"
      }
    }
  }
}
