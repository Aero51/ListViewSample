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


namespace ListViewSample
{
    class AssignmentListAdapter : BaseAdapter<Assignment_Model>
    {

        List<Assignment_Model> list_assignment_model;
        Activity context;
        readonly int resourceId;

        public AssignmentListAdapter(Activity context, List<Assignment_Model> list_assignment_model)
            : base()
        {
            this.context = context;
            this.list_assignment_model = list_assignment_model;
        }
        

        public override Assignment_Model this[int position]
        {
            get { return list_assignment_model[position]; }
        }

        public override int Count
        {
            get { return list_assignment_model.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var assignment = list_assignment_model[position];
            View view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.AssignmentItemLayout, null);
            }

            TextView name;
            name = view.FindViewById<TextView>(Resource.Id.assignmentName);
            name.Text = assignment.Assignment_Name;
            Spinner spinner = view.FindViewById<Spinner>(Resource.Id.assignmentStatus);

            var number = view.FindViewById<TextView>(Resource.Id.assignmentItemNumber).Text=assignment.Assignment_Number;
            var job = view.FindViewById<TextView> (Resource.Id.assignmentJob).Text=assignment.Assignment_Job;
         //  var  name = view.FindViewById<TextView>(Resource.Id.assignmentName).Text = assignment.Assignment_Name;
            var phone = view.FindViewById<TextView>(Resource.Id.assignmentPhone).Text = assignment.Assignment_Phone;
            var address = view.FindViewById<TextView>(Resource.Id.assignmentAddress).Text = assignment.Assignment_Adress;
            var buttonLayout = view.FindViewById<LinearLayout> (Resource.Id.assignmentButtonLayout);
            var timerLayout = view.FindViewById<LinearLayout> (Resource.Id.assignmentTimerLayout);
            var timerlinearLayout = view.FindViewById<LinearLayout> (Resource.Id.timerLinearLayout);
           // var spinner = view.FindViewById<Spinner> (Resource.Id.assignmentStatus);
            var spinnerImage = view.FindViewById<ImageView> (Resource.Id.assignmentStatusImage);
            var accept = view.FindViewById<Button> (Resource.Id.assignmentAccept);
            var decline = view.FindViewById<Button> (Resource.Id.assignmentDecline);
            var phoneButton = view.FindViewById<RelativeLayout> (Resource.Id.assignmentPhoneLayout);
            var mapButton = view.FindViewById<RelativeLayout> (Resource.Id.assignmentAddressLayout);

           

           // buttonLayout.Visibility = ViewStates.Visible;
            timerLayout.Visibility = ViewStates.Visible;
         
           
          //  accept.SetOnClickListener(OnClick(this));
            accept.Click += (sender, e) =>
            {
                accept.Text = " pressed";
                buttonLayout.Activated = false;
                buttonLayout.Visibility = ViewStates.Gone;
                name.Text = "test";
            };

           decline.Click += (sender, e) =>
            {
                decline.Text = "pressed";
            };
            

            return view;
        
        }

     
        public Assignment_Model GetItemAtPosition(int position)
        {
            return list_assignment_model[position];
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.assignmentAccept:
                    {
                        
                    }
                    break;
                case Resource.Id.assignmentDecline:
                    {
                       
                    }
                    break;
                case Resource.Id.assignmentPhoneLayout:
                    {
                        
                    }
                    break;
                case Resource.Id.assignmentAddressLayout:
                    {
                       
                    }
                    break;
                default:
                    break;
            }
        }

    }
}