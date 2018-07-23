package com.example.user.myapplication;

import android.content.Intent;
import android.database.Cursor;
import android.nfc.Tag;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class LoginActivity extends AppCompatActivity {

    EditText editTextEmail, editTextPwd;
    Button btnLogin, btnCancel;


    SQLiteHelper sh;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        editTextEmail = findViewById(R.id.editTextEmail);
        editTextPwd = findViewById(R.id.editTextPwd);

        btnLogin = findViewById(R.id.btnLogin);
        btnCancel = findViewById(R.id.btnCancel);


        sh = new SQLiteHelper(this,"Marathon2018.db", null,1);




        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if(editTextEmail.getText().toString()!="" &&editTextPwd.getText().toString()!=""){
//                    Toast.makeText(LoginActivity.this, "Wait", Toast.LENGTH_SHORT).show();

                    Cursor res = sh.login(editTextEmail.getText().toString(), editTextPwd.getText().toString());
                    //Toast.makeText(LoginActivity.this, res.getString(0), Toast.LENGTH_SHORT).show();

                    if(res.moveToNext())
                    {  // Toast.makeText(LoginActivity.this, "Welcome", Toast.LENGTH_SHORT).show();
                        startActivity(new Intent(LoginActivity.this, RunnerProfileActivity.class));
                    }
                    else{
                        Toast.makeText(LoginActivity.this, "Plz enter valid email and pwd", Toast.LENGTH_SHORT).show();
                    }
                }
                else {
                    Toast.makeText(LoginActivity.this, "Plz enter same password in both the fields", Toast.LENGTH_SHORT).show();
                }
            }
        });

        btnCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                startActivity(new Intent(LoginActivity.this, MainActivity.class));
            }
        });

    }
}
