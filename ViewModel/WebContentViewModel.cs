using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Workout_blazor.ViewModel;

public class WebContentViewModel : ObservableObject
{
    ////Example below////
    //public async Task<List<TodoItem>> RefreshDataAsync()
    //{
    //    Items = new List<TodoItem>();

    //    Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
    //    try
    //    {
    //        HttpResponseMessage response = await _client.GetAsync(uri);
    //        if (response.IsSuccessStatusCode)
    //        {
    //            string content = await response.Content.ReadAsStringAsync();
    //            Items = JsonSerializer.Deserialize<List<TodoItem>>(content, _serializerOptions);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Debug.WriteLine(@"\tERROR {0}", ex.Message);
    //    }

    //    return Items;
    //}
}
