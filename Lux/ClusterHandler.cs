namespace Lux;

internal sealed class ClusterHandler
{
    private const string ClusterFormationKey = "raft-matchmaker-cluster";

    private readonly RaftManager manager;

    public ClusterHandler(RaftManager manager)
    {
        this.manager = manager;
    }

    public async Task JoinCluster()
    {
        await Task.CompletedTask;

        //RedisConnection connection = await GetConnection();

        //await connection.BasicRetry(async database => await database.HashSetAsync(ClusterFormationKey, RaftManager.LocalEndpoint, RaftManager.GetCurrentTime()));
    }

    public async Task UpdateNodes()
    {
        long currentTime = RaftManager.GetCurrentTime();
        
        /*RedisConnection connection = await GetConnection();

        await connection.BasicRetry(async database => await database.HashSetAsync(ClusterFormationKey, RaftManager.LocalEndpoint, currentTime));

        HashEntry[] entries = await connection.BasicRetry(async database => await database.HashGetAllAsync(ClusterFormationKey));

        List<RaftNode> nodes = new(entries.Length);

        foreach (HashEntry entry in entries)
        {
            string? name = entry.Name;
            if (name is null)
                continue;

            if (entry.Name == RaftManager.LocalEndpoint)
                continue;

            string? value = entry.Value;
            if (value is null)
                continue;

            if (currentTime - long.Parse(value) >= 7500)
            {
                if (await manager.AmILeaderQuick(0))
                {
                    //manager.Logger.LogInformation("Removed node {Node} from cluster node list", entry.Name);

                    await connection.BasicRetry(async database => await database.HashDeleteAsync(ClusterFormationKey, entry.Name));
                }

                continue;
            }

            nodes.Add(new(name));
        }

        manager.Nodes = nodes;*/

        await Task.CompletedTask;
    }
}