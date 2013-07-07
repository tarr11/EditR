namespace EditR
open System
open ImpromptuInterface.FSharp
open Microsoft.AspNet.SignalR
open Microsoft.AspNet.SignalR.Hubs


[<HubName("editr")>]
type EditRHub() = 
    inherit Hub()
    member this.Ping() : unit =
        this.Clients.All?Ping();
