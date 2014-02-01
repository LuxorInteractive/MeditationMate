/*
    Meditation Mate v0.02

    File: LuxorEEGActivity.java
    ---------------------
    Luxor Interactive
    Luxor Group, Inc
    Copyright 2014 - All Rights Reserved
 */

package com.luxorinteractive.meditationmate;

import android.app.Activity;
import android.bluetooth.BluetoothAdapter;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.neurosky.thinkgear.TGDevice;
import com.neurosky.thinkgear.TGEegPower;

// Include Neurosky API

public class LuxorEEGActivity extends Activity {

    // Setup Bluetooth
    BluetoothAdapter bluetoothAdapter;

    // Create Text Views for MindWave Statistics
	TextView message;
    TextView status;
    TextView meditation;
    TextView attention;

	Button b;

    // Setup Mindwave device
	TGDevice tgDevice;
	final boolean rawEnabled = false;

    // Mindwave Connect
    public void mindwaveConnect(View view) {

        // Start Luxor EEG Activity Intent
        tgDevice.connect(rawEnabled);
    }


	
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.fragment_main);



        // Set Inputs
        message = (TextView)findViewById(R.id.message_input);
        status = (TextView)findViewById(R.id.status_input);
        meditation = (TextView)findViewById(R.id.meditation_input);
        attention = (TextView)findViewById(R.id.attention_input);

        //message.setText("");
        //status.setText("");

        // Show Android Version
        message.setText("Android version: " + Integer.valueOf(android.os.Build.VERSION.SDK) + "\n");

        bluetoothAdapter = BluetoothAdapter.getDefaultAdapter();

        // Check if Bluetooth Adapter was available
        if(bluetoothAdapter == null) {

        	// Alert user that Bluetooth is not available
        	Toast.makeText(this, "Bluetooth not available", Toast.LENGTH_LONG).show();


        }else {
        	/* create the TGDevice */
        	tgDevice = new TGDevice(bluetoothAdapter, handler);

            // Alert user that Bluetooth is available
            Toast.makeText(this, "Bluetooth available", Toast.LENGTH_LONG).show();
            //tgDevice.connect(rawEnabled);
            //tgDevice.getState();
        }
        // Getting Started Guide



    }



    @Override
    public void onDestroy() {
    	tgDevice.close();
        super.onDestroy();
    }
    /**
     * Handles messages from TGDevice
     */
    private final Handler handler = new Handler() {
        @Override
        public void handleMessage(Message msg) {
        	switch (msg.what) {
            case TGDevice.MSG_STATE_CHANGE:

                // State Change (Status Indicator)
                switch (msg.arg1) {
	                case TGDevice.STATE_IDLE:
	                    break;
	                case TGDevice.STATE_CONNECTING:		                	
	                	status.setText("Connecting...\n");
	                	break;		                    
	                case TGDevice.STATE_CONNECTED:
                        status.setText("Connected.\n");
	                	tgDevice.start();
	                    break;
	                case TGDevice.STATE_NOT_FOUND:
                        status.setText("Can't find\n");
	                	break;
	                case TGDevice.STATE_NOT_PAIRED:
                        status.setText("not paired\n");
	                	break;
	                case TGDevice.STATE_DISCONNECTED:
                        status.setText("Disconnected\n");
                }

                break;
            case TGDevice.MSG_POOR_SIGNAL:
            		//signal = msg.arg1;
                message.setText("PoorSignal: " + msg.arg1 + "\n");
                break;
            case TGDevice.MSG_RAW_DATA:	  
            		//raw1 = msg.arg1;
            		//tv.append("Got raw: " + msg.arg1 + "\n");
            	break;
            case TGDevice.MSG_HEART_RATE:
                message.setText("Heart rate: " + msg.arg1 + "\n");
                break;
            case TGDevice.MSG_ATTENTION:
            		//att = msg.arg1;
                attention.setText("Level: " + msg.arg1 + "\n");
            		//Log.v("HelloA", "Attention: " + att + "\n");
            	break;
            case TGDevice.MSG_MEDITATION:
                    //att = msg.arg1;
                meditation.setText("Level: " + msg.arg1 + "\n");
                    //Log.v("HelloA", "Meditation: " + att + "\n");
            	break;
            case TGDevice.MSG_EEG_POWER:
                TGEegPower ep = (TGEegPower)msg.obj;
                meditation.setText("EEG: " + ep.delta + "\n");
                //tvR.append("EEG: " + ep.delta + "\n");
                break;
            case TGDevice.MSG_BLINK:
                message.setText("Blink: " + msg.arg1 + "\n");
            	break;
            case TGDevice.MSG_RAW_COUNT:
            		//tv.append("Raw Count: " + msg.arg1 + "\n");
            	break;
            case TGDevice.MSG_LOW_BATTERY:
            	Toast.makeText(getApplicationContext(), "Low battery!", Toast.LENGTH_SHORT).show();
            	break;
            case TGDevice.MSG_RAW_MULTI:
            	//TGRawMulti rawM = (TGRawMulti)msg.obj;
            	//tv.append("Raw1: " + rawM.ch1 + "\nRaw2: " + rawM.ch2);
            default:
            	break;
        }
        }
    };
    
    public void doStuff() {
    	if(tgDevice.getState() != TGDevice.STATE_CONNECTING && tgDevice.getState() != TGDevice.STATE_CONNECTED)
    		tgDevice.connect(rawEnabled);
    	//tgDevice.ena
    }
}