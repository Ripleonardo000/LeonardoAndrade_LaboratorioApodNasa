using LeonardoAndrade_LaboratorioApodNasa.ViewModels;

namespace LeonardoAndrade_LaboratorioApodNasa.View;

public partial class LAApodPage : ContentPage
{
	public LAApodPage()
	{
		InitializeComponent();
        BindingContext = new LAApodViewModel();
    }
}