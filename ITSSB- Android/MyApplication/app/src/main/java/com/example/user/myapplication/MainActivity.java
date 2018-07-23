package com.example.user.myapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    Button btnRunner, btnSponsor, btnFindMore;
    TextView tvLogin, tvTimer;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnRunner = findViewById(R.id.btnLogin);
        btnSponsor = findViewById(R.id.btnCancel);
        btnFindMore = findViewById(R.id.btnFindMore);
        tvLogin = findViewById(R.id.tvLogin);
        tvTimer = findViewById(R.id.tvTimer);


        btnRunner.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(MainActivity.this, RunnerCompetedActivity.class));
            }
        });
        btnSponsor.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });
        btnFindMore.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });
        tvLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(MainActivity.this, LoginActivity.class));

            }
        });


    }
}
