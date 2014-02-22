using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewSample
{
    [Activity(Label = "ListViewSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {

		ListView assignmentsListView;
		LinearLayout assignmentActiveLayout;
		TextView number,
		name,
		job,
		phone,
		address,
		timerText;


        protected override void OnCreate(Bundle bundle)
        {




            base.OnCreate(bundle);
			//SetContentView(Resource.Layout.Main); 



			//var listView = FindViewById<ListView>(Resource.Id.listView1);
			//var data = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
			//listView.Adapter = new ArrayAdapter(this, Resource.Layout.ListViewTemplate1, data);


			/*		SetContentView(Resource.Layout.AssignmentsLayout); 
			 * 
			 * 
			 * 
				var listView = FindViewById<ListView>(Resource.Id.assignmentsListView);
				var data = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
				listView.Adapter = new ArrayAdapter (this, Resource.Layout.AssignmentItemLayout, data);
*/



			/*		SetContentView(Resource.Layout.MainLayoutTest); 

			assignmentsListView = FindViewById<ListView> (Resource.Id.mainLayoutTestListView);
			var data = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
			assignmentsListView.Adapter = new ArrayAdapter (this, Resource.Layout.ListViewTemplate1, data);
			*/
			int count = 0;
			//	Button button = FindViewById<Button> (Resource.Id.button1);
			//	button.Text = string.Format ("{0} clicks!!", count);






			//assignmentActiveLayout = FindViewById<LinearLayout> (Resource.Id.assignmentSelectedItem);
			//var view = new View (this);
			//view = inflator.Inflate (Resource.Layout.AssignmentItemLayout, null);
			//assignmentActiveLayout.AddView (view);


			SetContentView(Resource.Layout.MainLayoutTest); 
			assignmentsListView = FindViewById<ListView> (Resource.Id.mainLayoutTestListView);
			//assignmentActiveLayout = FindViewById<LinearLayout> (Resource.Id.assignmentSelectedItem);



			//	var view = new View (this);
			//	LayoutInflater inflator = (LayoutInflater)GetSystemService (Context.LayoutInflaterService);
			//		view = inflator.Inflate (Resource.Layout.AssignmentItemLayout, null);
			//	assignmentActiveLayout.AddView (view);
			//	view.LayoutParameters = new LinearLayout.LayoutParams (LinearLayout.LayoutParams.FillParent, LinearLayout.LayoutParams.WrapContent);
			//view.SetBackgroundDrawable (Resources.GetDrawable (Resource.Drawable.active_assignment_selector));


			var data = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
			assignmentsListView.Adapter = new ArrayAdapter (this, Resource.Layout.AssignmentItemLayout,Resource.Id.assignmentItemNumber, data);
			//assignmentsListView.Adapter = new ArrayAdapter (this, Resource.Layout.AssignmentItemLayout, data);






        }
    }
}

