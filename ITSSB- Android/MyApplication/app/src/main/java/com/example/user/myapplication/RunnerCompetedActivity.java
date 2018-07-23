package com.example.user.myapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class RunnerCompetedActivity extends AppCompatActivity {

    Button btnCompetedBefore, btnNew;
    TextView tvLogin;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_runner_competed);
        btnCompetedBefore = findViewById(R.id.btnLogin);
        btnNew = findViewById(R.id.btnCancel);
        tvLogin = findViewById(R.id.tvLogin);
        btnCompetedBefore.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(RunnerCompetedActivity.this, RegisterActivity.class));
            }
        });

        btnNew.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(RunnerCompetedActivity.this, RegisterActivity.class));
            }
        });
        tvLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(RunnerCompetedActivity.this, LoginActivity.class));
            }
        });
    }
}


