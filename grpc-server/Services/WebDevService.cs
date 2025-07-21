using Grpc.Core;
using grpc_server;
using grpc_server.Services;

namespace grpc_server.Services;

public class WebDevService : WebDev.WebDevBase
{
    public override Task<ProjectConfirmation> CreateProject(Project request, ServerCallContext context)
    {
        return Task.FromResult(new ProjectConfirmation
        {
            Msg = "Project created successfully"
        });
    }
}