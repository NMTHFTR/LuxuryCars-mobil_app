using System.Security.AccessControl;

namespace LuxuryCars.Views;

public partial class Speedometer : ContentPage
{
    public  Speedometer()
    {
        InitializeComponent();
        ToggleAccelerometer();
        mertLBL.Text = Preferences.Get("key","még nincs mérés");
    }
    

   

    public void ToggleAccelerometer()
    {
        if (Accelerometer.Default.IsSupported)
        {
            if (!Accelerometer.Default.IsMonitoring)
            {
                // Turn on accelerometer
                Accelerometer.Default.ReadingChanged += Accelerometer_ReadingChanged;
                Accelerometer.Default.Start(SensorSpeed.UI);
            }
            else
            {
                // Turn off accelerometer
                Accelerometer.Default.Stop();
                Accelerometer.Default.ReadingChanged -= Accelerometer_ReadingChanged;
            }
        }
    }
    private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
    {
        double osszsebesseg = Math.Sqrt((e.Reading.Acceleration.Y * e.Reading.Acceleration.Y) + (e.Reading.Acceleration.X * e.Reading.Acceleration.X) + (e.Reading.Acceleration.Z * e.Reading.Acceleration.Z));
            osszsebesseg=osszsebesseg * 3.6;
        osszsebesseg=osszsebesseg-3.6;
        osszsebesseg = Math.Round(osszsebesseg, 0);
        osszsebesseg = Math.Abs(osszsebesseg);

        //sebesseg.TextColor = Colors.Green;
        sebesseg.Text = $"{osszsebesseg} km/h";

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Preferences.Set("key",sebesseg.Text);
        mertLBL.Text = Preferences.Get("key", sebesseg.Text);
        SemanticScreenReader.Announce(sebesseg.Text);
         
    }
}