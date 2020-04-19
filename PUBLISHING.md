# Publishing

_Here is a check list for publishing a new version:_

-   [] Checkout the canary branch and make sure `CHANGELOG.md` is up to date.
-   [] Update the version number in all `package.json` files (on the root and in all the `Packages/<PackageName>/package.json`)
-   [] Update the root `README.md` file with the correct version. Also update the version in `docs/introduction/quick-start.md`.
-   [] From the root run `npm run generate:docs` to make sure all API documentation is up to date.
-   [] Commit and push your changes to the canary branch.
-   [] Merge the canary branch into the master branch.
-   [] Publish a new version of the website.
    -   [] Go (via the terminal) to the `website` folder.
    -   [] Run `npm start` to test and see that it runs as expected.
    -   [] Run `GIT_USER=<your-username> \ CURRENT_BRANCH=master \ npm run publish-gh-pages` to publish the website.
-   [] Create a new release under `releases` on the Github repo.
-   [] From the root run `npm run publish:all`. This is only possible for me (Adam Ramberg) at the moment. Will need to look into a solution for this.
