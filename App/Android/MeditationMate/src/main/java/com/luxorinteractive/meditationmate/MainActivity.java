/*
    Meditation Mate v0.02

    File: MainActivity.java
    ---------------------
    Luxor Interactive
    Luxor Group, Inc
    Copyright 2014 - All Rights Reserved
 */

package com.luxorinteractive.meditationmate;

import android.app.Dialog;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;

public class MainActivity extends ActionBarActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        /*
        if (savedInstanceState == null) {
            getSupportFragmentManager().beginTransaction()
                    .add(R.id.container, new PlaceholderFragment())
                    .commit();
        }
        */
    }

    // Launch Getting Started
    public void gettingStarted(View view) {

        //
        final Dialog guide = new Dialog(MainActivity.this);
        guide.setContentView(R.layout.guide_overlay);
        guide.setTitle("Getting Started");
        guide.setCancelable(true);

        guide.show();

        //set up button
        Button cancelbutton = (Button) guide.findViewById(R.id.Button01);
        cancelbutton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                // Return to Dashboard (Main Activity) Intent
                guide.dismiss();
                //Intent connectToMindwave = new Intent(MainActivity.this, MainActivity.class);
                //startActivity(connectToMindwave);
            }
        });
    }

    // Launch Mindwave Configure
    public void mindwaveConfigure(View view) {

        // Start Luxor EEG Activity Intent
        Intent connectToMindwave = new Intent(MainActivity.this, LuxorEEGActivity.class);
        startActivity(connectToMindwave );
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {

        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }





    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        switch (item.getItemId()) {
            case R.id.action_settings:
                return true;
        }
        return super.onOptionsItemSelected(item);
    }

    /**
     * A placeholder fragment containing a simple view.
     */
    /*
    public static class PlaceholderFragment extends Fragment {

        public PlaceholderFragment() {
        }

        @Override
        public View onCreateView(LayoutInflater inflater, ViewGroup container,
                Bundle savedInstanceState) {
            View rootView = inflater.inflate(R.layout.fragment_main, container, false);
            return rootView;
        }
    }
    */
}
