import { Union } from "./.fable/fable-library.3.1.16/Types.js";
import { union_type } from "./.fable/fable-library.3.1.16/Reflection.js";
import { singleton, tail, head, isEmpty } from "./.fable/fable-library.3.1.16/List.js";
import { RouterModule_encodeParts } from "./.fable/Feliz.Router.3.8.0/Router.fs.js";

export class Page extends Union {
    constructor(tag, ...fields) {
        super();
        this.tag = (tag | 0);
        this.fields = fields;
    }
    cases() {
        return ["FableReactNative", "FableReactNativeInstallation", "FableReactNativeProps"];
    }
}

export function Page$reflection() {
    return union_type("Router.Page", [], Page, () => [[], [], []]);
}

export const defaultPage = new Page(0);

export function parseUrl(_arg1) {
    let pattern_matching_result;
    if (!isEmpty(_arg1)) {
        if (head(_arg1) === "") {
            if (isEmpty(tail(_arg1))) {
                pattern_matching_result = 0;
            }
            else {
                pattern_matching_result = 3;
            }
        }
        else if (head(_arg1) === "installation") {
            if (isEmpty(tail(_arg1))) {
                pattern_matching_result = 1;
            }
            else {
                pattern_matching_result = 3;
            }
        }
        else if (head(_arg1) === "props") {
            if (isEmpty(tail(_arg1))) {
                pattern_matching_result = 2;
            }
            else {
                pattern_matching_result = 3;
            }
        }
        else {
            pattern_matching_result = 3;
        }
    }
    else {
        pattern_matching_result = 3;
    }
    switch (pattern_matching_result) {
        case 0: {
            return new Page(0);
        }
        case 1: {
            return new Page(1);
        }
        case 2: {
            return new Page(2);
        }
        case 3: {
            return defaultPage;
        }
    }
}

export function getHref(_arg1) {
    switch (_arg1.tag) {
        case 1: {
            return RouterModule_encodeParts(singleton("installation"), 1);
        }
        case 2: {
            return RouterModule_encodeParts(singleton("props"), 1);
        }
        default: {
            return RouterModule_encodeParts(singleton(""), 1);
        }
    }
}

