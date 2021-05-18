import { Model, Msg, ModelModule_init } from "./Domain.fs.js";
import { Cmd_OfAsync_start, Cmd_OfAsyncWith_perform, Cmd_none } from "./.fable/Fable.Elmish.3.1.0/cmd.fs.js";
import { singleton } from "./.fable/fable-library.3.1.16/AsyncBuilder.js";
import { sleep } from "./.fable/fable-library.3.1.16/Async.js";

export function init() {
    return [ModelModule_init, Cmd_none()];
}

function delay(msg) {
    return singleton.Delay(() => singleton.Bind(sleep(2000), () => singleton.Return(msg)));
}

export function update(msg, currentModel) {
    switch (msg.tag) {
        case 2: {
            const page = msg.fields[0];
            return [currentModel, Cmd_none()];
        }
        case 1: {
            const cmd = (!currentModel.ShowLoader) ? Cmd_OfAsyncWith_perform((x_1) => {
                Cmd_OfAsync_start(x_1);
            }, (msg_1) => delay(msg_1), new Msg(1), (x) => x) : Cmd_none();
            return [new Model(currentModel.CurrentPage, currentModel.ShowQuickView, !currentModel.ShowLoader), cmd];
        }
        default: {
            const p = msg.fields[0];
            return [new Model(p, currentModel.ShowQuickView, currentModel.ShowLoader), Cmd_none()];
        }
    }
}

