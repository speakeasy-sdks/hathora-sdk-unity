# CreateLocalLobbyRequestBody


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `initialConfig`                                                            | [LobbyInitialConfig](../../Models/Shared/LobbyInitialConfig.md)            | :heavy_check_mark:                                                         | User input to initialize the game state. Object must be smaller than 64KB. |
| `region`                                                                   | [Region](../../Models/Shared/Region.md)                                    | :heavy_check_mark:                                                         | Available regions to request a game server.                                |