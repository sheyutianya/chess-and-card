package com.shulu.downmono;

import com.unity3d.player.UnityPlayerActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;

public class MainActivity extends UnityPlayerActivity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		Log.d("Main", "Main");
	}
	
	public void restartApplication()
	{  
		new Thread()
		{
			public void run()
			{
				Intent launch=getBaseContext().getPackageManager().getLaunchIntentForPackage(getBaseContext().getPackageName());
				launch.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
				startActivity(launch);  
				android.os.Process.killProcess(android.os.Process.myPid());
			}
		}.start();
		finish();	 
	}

}
