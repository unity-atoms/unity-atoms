/**
 * Copyright (c) 2017-present, Facebook, Inc.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

const React = require("react");

const CompLibrary = require("../../core/CompLibrary.js");

const {MarkdownBlock, GridBlock, Container} = CompLibrary; /* Used to read markdown */

const siteConfig = require(`${process.cwd()}/siteConfig.js`);

function docUrl(doc, language) {
  return `${siteConfig.baseUrl}${language ? `${language}/` : ""}${doc}`;
}

function imgUrl(img) {
  return `${siteConfig.baseUrl}img/${img}`;
}

class Button extends React.Component {
  render() {
    return (
      <div className="pluginWrapper buttonWrapper">
        <a className="button hero" href={this.props.href} target={this.props.target}>
          {this.props.children}
        </a>
      </div>
    );
  }
}

Button.defaultProps = {
  target: "_self"
};

const SplashContainer = props => (
  <div className="homeContainer">
    <div className="homeSplashFade">
      <div className="wrapper homeWrapper">{props.children}</div>
    </div>
  </div>
);

const ProjectTitle = () => (
  <React.Fragment>
    <div style={{display : "flex", justifyContent : "center", alignItems : "center"}}>
      <img src={"img/atom-icon-pure-purple.png"} className="homeLogo" alt="Unity Atoms logo" width={82} height={82} style={{ marginRight: '0.5rem' }}/>
      <h1 className="projectTitle">{siteConfig.title}</h1>
    </div>

    <h2 style={{marginTop : "0.5em"}}>
        Tiny modular pieces utilizing the power of Scriptable Objects
    </h2>
    </React.Fragment>
);

const PromoSection = props => (
  <div className="section promoSection">
    <div className="promoRow">
      <div className="pluginRowBlock">{props.children}</div>
    </div>
  </div>
);

class HomeSplash extends React.Component {
  render() {
    const language = this.props.language || "";
    return (
      <SplashContainer>
        <div className="inner">
          <ProjectTitle />
          <PromoSection>
            <Button href={docUrl("introduction/quick-start", language)}>
              Get Started
            </Button>
          </PromoSection>
        </div>
      </SplashContainer>
    );
  }
}

const Block = props => (
  <Container
    id={props.id}
    background={props.background}
    className={props.className}
  >
    <GridBlock align="center" contents={props.children} layout={props.layout}/>
  </Container>
);

const FeaturesTop = props => (
  <Block layout="threeColumn" className="featureBlock">
    {[
      {
        content: "Avoid scripts and systems directly dependent on each other.",
        image : imgUrl("box.svg"),
        imageAlign: 'top',
        title: "Modular"
      },
      {
        content: "Scriptable Objects makes it possible to make changes to your game at runtime.",
        image : imgUrl("pen.svg"),
        imageAlign: 'top',
        title: "Editable"
      },
      {
        content: "Modular code is easier to debug than tightly coupled code.",
        image : imgUrl("bug.svg"),
        imageAlign: 'top',
        title: "Debuggable"
      },
    ]}
  </Block>
);


class Index extends React.Component {
  render() {
    const language = this.props.language || "";

    return (
      <div className="homeMainWrapper">
        <HomeSplash language={language} />
        <Container background="light">
            <div style={{ paddingTop: '3rem', paddingBottom: '3rem' }}>
                <FeaturesTop />
            </div>
        </Container>
      </div>
    );
  }
}

module.exports = Index;
