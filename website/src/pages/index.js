import React from "react";
import Layout from "@theme/Layout";
import Link from "@docusaurus/Link";
import useDocusaurusContext from "@docusaurus/useDocusaurusContext";
import clsx from "clsx";
import styles from "./index.module.css"; // optional, for custom CSS modules
import atomsLogo from "@site/static/img/atoms-logo.svg";
import icon_modular from "@site/static/img/box.svg";
import icon_editable from "@site/static/img/pen.svg";
import icon_debuggable from "@site/static/img/bug.svg";

const FeatureList = [
  {
    title: "Modular",
    image: <icon_modular />,
    description: "Avoid scripts and systems directly dependent on each other.",
  },
  {
    title: "Editable",
    image: <icon_editable />,
    description:
      "Scriptable Objects makes it possible to make changes to your game at runtime.",
  },
  {
    title: "Debuggable",
    image: <icon_debuggable />,
    description: "Modular code is easier to debug than tightly coupled code.",
  },
];

function Feature({ image, title, description }) {
  return (
    <div className={clsx("col col--4", styles.feature)}>
      <div className="text--center">
        {image}
      </div>
      <div className="text--center padding-horiz--md">
        <h3>{title}</h3>
        <p>{description}</p>
      </div>
    </div>
  );
}

function HomepageHeader() {
  const { siteConfig } = useDocusaurusContext();
  return (
    <header className={clsx("hero hero--primary", styles.heroBanner)}>
      <div className="container">
        <div className={styles.logoRow}>
          <atomsLogo className={styles.logoPurple} />
          <h1 className="hero__title">{siteConfig.title}</h1>
        </div>
        <p className={clsx("hero__subtitle", "text--center")}>
          Tiny modular pieces utilizing the power of Scriptable Objects
        </p>
        <div className={clsx("margin-top--md", "text--center")}>
          <Link
            className="button button--secondary button--lg"
            to="/docs/introduction/installation"
          >
            Get Started
          </Link>
        </div>
      </div>
    </header>
  );
}

function HomepageFeatures() {
  return (
    <section className={styles.featuresSection}>
      <div className={styles.featuresContainer}>
        <div className={clsx("container")}>
          <div className="row">
            {FeatureList.map((props, idx) => (
              <Feature key={idx} {...props} />
            ))}
          </div>
        </div>
      </div>
    </section>
  );
}

export default function Home() {
  return (
    <Layout>
      <HomepageHeader />
      <main className={clsx("mainContainer", styles.mainContainer)}>
        <HomepageFeatures />
      </main>
    </Layout>
  );
}
