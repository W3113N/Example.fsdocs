(**
## This is my Page (Edited)
*)


#load "YahooFinance.fsx"


open YahooFinance

let twnk = YahooFinance.PriceHistory("TWNK")

twnk.[..3]

(***include-it***)


#r "nuget: Plotly.NET, 2.0.0-preview.17"

open Plotly.NET

twnk // Prices List

|> List.map (fun day -> day.Date, day.AdjustedClose)
|>Chart.Line
|>GenericChart.toChartHTML


(***include-it-raw***)
