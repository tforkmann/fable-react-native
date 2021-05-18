module Views.Fable.React.Native.Props

open Fable.React
open Browser.Dom
open Feliz
open Feliz.Bulma
open Shared

let props =
    div [ Props.Style [
              Props.CSSProp.Height 150
          ] ] [
          
          ]

let overview =
    Html.div
        [ Bulma.title.h1 [ Html.text "Fable.React.Native Props" ]
          Bulma.content
              [ Html.p "Here are soem props for Fable.React.Native"
                props
                code """
                ReactFlow.flowChart [
                    ReactFlow.elements [|
                        ReactFlow.node [
                            node.id "1"
                            node.nodetype Input
                            node.data {| label = "Erdgas Einsatz" |}
                            node.style [
                                style.background "yellow"
                                style.color "#332"
                                style.border "1px solid #222138"
                                style.width 180
                            ]
                            node.position (20, 5)
                        ]
                        ReactFlow.node [
                            node.id "2"
                            node.nodetype Default
                            node.data {| label = "CityCube" |}
                            node.style [
                                style.background "#2e88c9"
                                style.color "white"
                                style.border "1px solid #222138"
                                style.width 180
                            ]
                            node.position (250, 5)
                        ]
                        ReactFlow.node [
                            node.id "3"
                            node.nodetype Output
                            node.data {| label = "Strom Absatz" |}
                            node.style [
                                style.background "lightblue"
                                style.color "#333"
                                style.border "1px solid #222138"
                                style.width 180
                            ]
                            node.position (100, 100)
                        ]
                        ReactFlow.node [
                            node.id "4"
                            node.nodetype Output
                            node.data {| label = "Wärme Absatz" |}
                            node.style [
                                style.background "red"
                                style.color "white"
                                style.border "1px solid #222138"
                                style.width 180
                            ]
                            node.position (100, 100)
                        ]
                        ReactFlow.edge [
                            edge.id "e1-2"
                            edge.source "1"
                            edge.target "2"
                            edge.animated false
                            edge.label "100 MWh"
                            edge.edgeType SmoothStep
                            edge.arrowHeadType ArrowClosed
                            edge.style [ style.stroke "yellow" ]
                            edge.labelStyle [
                                labelStyle.fill "black"
                                labelStyle.fontWeight 700
                            ]
                        ]
                        ReactFlow.edge [
                            edge.id "e2-3"
                            edge.source "2"
                            edge.target "3"
                            edge.animated true
                            edge.label "50 MWh"
                            edge.edgeType SmoothStep
                            edge.arrowHeadType ArrowClosed
                            edge.style [ style.stroke "blue" ]
                            edge.labelStyle [
                                labelStyle.fill "blue"
                                labelStyle.fontWeight 700
                            ]
                        ]
                        ReactFlow.edge [
                            edge.id "e2-4"
                            edge.source "2"
                            edge.target "4"
                            edge.animated true
                            edge.label "55 MWh"
                            edge.edgeType SmoothStep
                            edge.arrowHeadType ArrowClosed
                            edge.style [ style.stroke "red" ]
                            edge.labelStyle [
                                labelStyle.fill "red"
                                labelStyle.fontWeight 700
                            ]
                        ]
                    |]
                    ReactFlow.onElementClick
                        (fun (x, y) ->
                            console.log y
                            window.alert "You clicked me!")
                    ReactFlow.onNodeDragStop
                        (fun (x, y) ->
                            console.log y
                            window.alert "You dragged me!")
                    ReactFlow.onElementsRemove
                        (fun (x, y) ->
                            console.log y
                            window.alert "You removed me!")
                    ReactFlow.onConnect
                        (fun (x, y) ->
                            console.log y
                            window.alert "You connected me!")
                    ReactFlow.onConnectStart
                        (fun (x, y) ->
                            console.log y
                            window.alert "You started to connect me!")
                ]
                """ ]
          fixDocsView "FelizReactFlow.ExampleFlow" false      ]


// https://github.com/tforkmann/Feliz.ReactFlow/blob/main/src/Docs/views/Feliz.ReactFlow/FelizReact.ExampleFlow.fs
// https://github.com/tforkmann/Feliz.ReactFlow/blob/main/src/Docs/views/Feliz.ReactFlow/FelizReactFlow.ExampleFlow.fs