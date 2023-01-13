using System;
using System.Collections;
using System.Collections.Generic;
using Fusion;
using Fusion.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotonScript : MonoBehaviour, INetworkRunnerCallbacks
{
    [SerializeField] private NetworkPrefabRef prefabHost;
    [SerializeField] private NetworkPrefabRef prefabClient;
    
    public void OnPlayerJoined(NetworkRunner runner, PlayerRef player)
    {
        Debug.Log("プレイヤーが入室しました");
        Debug.Log(runner.GameMode);
        if(runner.GameMode == GameMode.Host)
        {
            Debug.Log("host");
            runner.Spawn(prefabHost, new Vector3(-6, -3.2f, 0), Quaternion.identity, player);
            runner.Spawn(prefabClient, new Vector3(6, -3.2f,0), Quaternion.identity, player);
        }
    }

    public void OnPlayerLeft(NetworkRunner runner, PlayerRef player)
    {
        Debug.Log("プレイヤーが退室しました");
    }

    public void OnInput(NetworkRunner runner, Fusion.NetworkInput input)
    {
        
    }

    public void OnInputMissing(NetworkRunner runner, PlayerRef player, Fusion.NetworkInput input)
    {
        
    }

    public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
    {
    }

    public void OnConnectedToServer(NetworkRunner runner)
    {
    }

    public void OnDisconnectedFromServer(NetworkRunner runner)
    {
    }

    public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token)
    {
    }

    public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
    {
    }

    public void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
    {
    }

    public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
    {
    }

    public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
    {
    }

    public void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
    {
    }

    public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<byte> data)
    {
    }

    public void OnSceneLoadDone(NetworkRunner runner)
    {
    }

    public void OnSceneLoadStart(NetworkRunner runner)
    {
    }

    public void OnClickHost()
    {
        StartGame(GameMode.Host);
    }

    public void OnClickClient()
    {
        StartGame(GameMode.Client);
    }
    
    private NetworkRunner _networkRunner;

    private void StartGame(GameMode mode)
    {
        _networkRunner = GetComponent<NetworkRunner>();
        _networkRunner.ProvideInput = true;

        _networkRunner.StartGame(new StartGameArgs()
        {
            GameMode = mode,
            SessionName = "PlayRoom",
            Scene = SceneManager.GetActiveScene().buildIndex
            //SceneObjectProvider = GetComponent<NetworkSceneManagerDefault>()
        });
    }
}