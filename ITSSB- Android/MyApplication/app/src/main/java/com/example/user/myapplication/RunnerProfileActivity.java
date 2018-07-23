package com.example.user.myapplication;

import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class RunnerProfileActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_runner_profile);

        Button btn = findViewById(R.id.btnFindMore);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                AlertDialog.Builder ad = new AlertDialog.Builder(RunnerProfileActivity.this);
                ad.setCancelable(true);
                ad.setTitle("Conact Information");
                ad.setMessage("Fore more info contact\n\n phone no: 90909090 \n\n email:cam@mac.com");
                ad.show();
            }
        });
    }
}
