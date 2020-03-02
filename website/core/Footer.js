/**
 * Copyright (c) 2017-present, Facebook, Inc.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

const React = require('react');

class Footer extends React.Component {
  docUrl(doc, language) {
    const { config } = this.props;
    const { baseUrl, docsUrl } = config;
    const docsPart = `${docsUrl ? `${docsUrl}/` : ''}`;
    const langPart = `${language ? `${language}/` : ''}`;
    return `${baseUrl}${docsPart}${langPart}${doc}`;
  }

  pageUrl(doc, language) {
    const { config } = this.props;
    const { baseUrl } = config;
    return baseUrl + (language ? `${language}/` : '') + doc;
  }

  render() {
    const { config } = this.props;
    const { baseUrl, footerIcon, title, repoUrl, copyright } = config;

    return (
      <footer className="nav-footer" id="footer">
        <section className="sitemap">
          <a href={baseUrl} className="nav-home">
            {footerIcon && (
              <img
                src={baseUrl + footerIcon}
                alt={title}
                style={{ width: '52px', height: '52px' }}
              />
            )}
          </a>
          <div>
            <h5>Docs</h5>
            <a href={this.docUrl('introduction/quick-start')}>Quick Start</a>
            <a href={this.docUrl('api/actions')}>API</a>
            <a href={this.docUrl('subpackages/base-atoms')}>Subpackages</a>
          </div>
          <div>
            <h5>Community</h5>
            <a
              href="https://discord.gg/W4yd7E7"
              target="_blank"
              rel="noreferrer noopener"
            >
              Discord
            </a>
            <a
              href="https://gitter.im/unity-atoms/community#"
              target="_blank"
              rel="noreferrer noopener"
            >
              Gitter
            </a>
          </div>
          <div>
            <h5>More</h5>
            <a href="https://medium.com/@adamramberg">Blog</a>
            <a href="https://github.com/AdamRamberg/unity-atoms">GitHub</a>
            <a
              className="github-button"
              href={repoUrl}
              data-icon="octicon-star"
              data-count-href="/AdamRamberg/unity-atoms/stargazers"
              data-show-count="true"
              data-count-aria-label="# stargazers on GitHub"
              aria-label="Star this project on GitHub"
            >
              Star
            </a>
          </div>
        </section>
        <section className="copyright">{copyright}</section>
      </footer>
    );
  }
}

module.exports = Footer;
