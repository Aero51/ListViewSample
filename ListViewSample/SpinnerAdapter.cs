using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;


namespace ListViewSample
{
   public class SpinnerAdapter<T>:BaseAdapter,ISpinnerAdapter{
       List<string> items;
       Context context;
       int resourceId;
public SpinnerAdapter(T[]items, Context context , int resourceId): base()
       {
           this.items = new List<string>();
           foreach (var item in items)
           {
               this.items.Add(item.ToString());
           }
           this.context = context;
           this.resourceId = resourceId;
       }

public override Java.Lang.Object GetItem(int position)
{
    return items[position];
}

public override int Count
{
    get { return items.Count; }
}

public override long GetItemId(int position)
{
    return (long)position;
}

/// <summary>
/// Text color for the item
/// </summary>
/// 
      
public Color TextColor
{
    get;
    set;
}

/// <summary>
/// Background color of the text view
/// </summary>
public Color Background
{
    get;
    set;
}

public override View GetView(int position, View convertView, ViewGroup parent)
{
    var view = convertView;
    if (view == null)
    {
        LayoutInflater inflator = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
        view = inflator.Inflate(resourceId, null);
    }

    var item = items.ElementAtOrDefault(position);
    if (item == null)
    {
        return view;
    }

    var textView = view.FindViewById<TextView>(Resource.Id.simpleSpinnerTextView);
    textView.Text = item;
    textView.SetTextColor(TextColor);
    textView.SetBackgroundColor(Background);
    return view;
}

protected override void Dispose(bool disposing)
{
    context = null;
    base.Dispose(disposing);
}
   }
}