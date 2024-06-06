
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using BusinessLayer.Services.ViewModel;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// About service implementation providing specific operations for About.
/// </summary>
public class AboutService : GenericService<About>, IAboutService
{
    private readonly IUnitOfWork unitOfWork;
    public AboutService(IUnitOfWork _unitOfWork) : base(_unitOfWork.Abouts, _unitOfWork)
    {
        this.unitOfWork=_unitOfWork;
    }
    

    public async Task<AboutViewModel> GetAboutPageDataAsync()
    {
        var aboutList = await unitOfWork.Abouts.GetAllAsync();

        var viewModel = new AboutViewModel
        {
            HeaderDescription = await unitOfWork.Abouts.GetDescriptionByNameAsync("Header"),
            ImageUrl = await unitOfWork.Abouts.GetDescriptionByNameAsync("Img"),
            StoryDescription = await unitOfWork.Abouts.GetDescriptionByNameAsync("Story"),
            MissionDescription = await unitOfWork.Abouts.GetDescriptionByNameAsync("Mission"),
            ValueDescription = await unitOfWork.Abouts.GetDescriptionByNameAsync("Value")
        };

        return viewModel;
    }
    public async Task<string> GetDescriptionByNameAsync(string name)
    {
        return await unitOfWork.Abouts.GetDescriptionByNameAsync(name);
    }
}
