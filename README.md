CoffeeFinder-XamarinDemo
========================

This is the demo app I built during my presentation at [NoVA Mobile C# Dev Group on 3/12/2014](http://forums.xamarin.com/discussion/12518/march-12-northern-virginia-mobile-c-developers-group-first-meeting#latest)

**Ed Snider** [@edsnider](http://www.twitter.com/edsnider) | [www.edsnider.net](http://www.edsnider.net) | [www.novamobiledev.org](http://www.novamobiledev.org)

###About this demo app
This was a simple demo showing how to use Xamarin to build mobile apps on multiple platforms.  This demo includes a Windows Phone 8 app and an Android app and was built to demonstrate the following cross-platform app dev concepts:

- Using [Xamarin w/ Visual Studio](http://xamarin.com/visual-studio)
- Using the MVVM pattern - [MvvmCross](https://github.com/MvvmCross/MvvmCross) was used in this demo
- Using System.Net.Http to get data from a REST endpoint - the [Foursquare Venues Search API](https://developer.foursquare.com/docs/venues/search) was used in this demo
- Using Portable Class Libraries (PCLs) to share core code and logic
- Using interfaces to specify services that are implemented specifically for each platform (see `CoffeeFinder.Core.Services.ILocationService` ) 
- Using [Xamarin Components](http://components.xamarin.com/) - the [Xamarin.Mobile](http://components.xamarin.com/view/xamarin.mobile/) component was used to get Geolocation information in the Android app (I could have used this component on the WP8 app too but just used the regular API) 

This is what the apps looked like at the end of the demo:

![](http://edsnider.files.wordpress.com/2014/03/coffeefinderscreenshots.png)

###Running the code
If you want to download or fork this code you'll need to get a Foursquare API Client ID and Client Secret and drop them into the `CoffeeFinder.Core.Services.FoursquareService` class.  You can get this from [https://developer.foursquare.com/start](https://developer.foursquare.com/start). 

**Package dependencies**

You will also need the following NuGet packages:

for the CoffeeFinder.Core project:

- Json.NET
- Microsoft HTTP Client Libraries
- MvvmCross

for the CoffeeFinder.Android project:

- MvvmCross
- MvvmCross Visibility Plugin (used for the Visibility converter)

for the CoffeeFinder.WP8 project:

- MvvmCross
- Microsoft HTTP Client Libraries

In addition to the above NuGet packages you will also need to add a Framework Reference to System.Net.Http in the CoffeeFinder.Android project since it can actually use it and doesn't need the PCL version.

####Questions
If you have any question please feel free to reach out to me.

-[@edsnider](http://www.twitter.com/edsnider)