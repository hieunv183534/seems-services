using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace VNEmsResource.Samples;

[Area(VNEmsResourceRemoteServiceConsts.ModuleName)]
[RemoteService(Name = VNEmsResourceRemoteServiceConsts.RemoteServiceName)]
[Route("api/VNEmsResource/sample")]
public class SampleController : VNEmsResourceController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
