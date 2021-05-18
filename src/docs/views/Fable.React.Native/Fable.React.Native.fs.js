import { createElement } from "react";
import { Interop_reactApi } from "../../.fable/Feliz.1.45.0/Interop.fs.js";
import { ofArray } from "../../.fable/fable-library.3.1.16/List.js";
import { installationView, fixDocsView } from "../../Shared.fs.js";

export const overview = (() => {
    let elms;
    const children_2 = ofArray([(elms = ofArray(["Fable.React.Native - Documentation", createElement("a", {
        href: "https://www.nuget.org/packages/Fable.React.Native /",
        children: Interop_reactApi.Children.toArray([createElement("img", {
            src: "https://img.shields.io/nuget/v/Fable.React.Native.svg?style=flat",
        })]),
    })]), createElement("h1", {
        className: "title is-1",
        children: Interop_reactApi.Children.toArray(Array.from(elms)),
    })), createElement("h2", {
        className: "subtitle is-2",
        children: Interop_reactApi.Children.toArray(["Fable bindings and helpers for React Native projects."]),
    }), createElement("hr", {}), fixDocsView("Fable.React.Native", false)]);
    return createElement("div", {
        children: Interop_reactApi.Children.toArray(Array.from(children_2)),
    });
})();

export const installation = installationView("Fable.React.Native");

