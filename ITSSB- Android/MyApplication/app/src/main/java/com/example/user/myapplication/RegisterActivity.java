package com.example.user.myapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

public class RegisterActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener {

    EditText edtTxtEmail, edtTxtPwd, editTxtPwdAgain, editTxtFirstName, editTxtLastName;
    Spinner spinnerGender;
    Button btnRegister, btnCancel;

    SQLiteHelper sh;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        editTxtFirstName = findViewById(R.id.editTextFirstName);
        editTxtLastName = findViewById(R.id.editTextLastName);
        edtTxtEmail = findViewById(R.id.editTextEmail);
        edtTxtPwd = findViewById(R.id.editTextPwd);
        editTxtPwdAgain = findViewById(R.id.editTextPwdAgain);
        spinnerGender = findViewById(R.id.spinnerGender);

        btnRegister = findViewById(R.id.btnRegister);
        btnCancel = findViewById(R.id.btnCancel);

        ArrayList<String> gender = new ArrayList<String>();
        gender.add("Male");
        gender.add("Female");

        ArrayAdapter<String> ad = new ArrayAdapter<String>(RegisterActivity.this, R.layout.support_simple_spinner_dropdown_item, gender);

        spinnerGender.setOnItemSelectedListener(RegisterActivity.this);
        spinnerGender.setAdapter(ad);

        sh = new SQLiteHelper(this,"Marathon2018.db", null,1);

        sh.createTable("create table if not exists register(id integer primary key autoincrement, email varchar unique not null, pwd varchar not null, fName varchar not null, lName varchar not null, gender varchar not null)");

        btnRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if((edtTxtPwd.getText().toString()!="") && (editTxtFirstName.getText().toString()!="") && (editTxtLastName.getText().toString()!="") && (editTxtPwdAgain.getText().toString()!="") && (edtTxtEmail.getText().toString()!="")){
                if(edtTxtPwd.getText().toString().equals(editTxtPwdAgain.getText().toString())){
                    sh.insertTable(edtTxtEmail.getText().toString(),edtTxtPwd.getText().toString() , editTxtFirstName.getText().toString(),editTxtLastName.getText().toString() , spinnerGender.getSelectedItem().toString());
                    startActivity(new Intent(RegisterActivity.this, RegisterSuccessActivity.class));

                }
                else {
                    Toast.makeText(RegisterActivity.this, "Plz enter same password in both the fields", Toast.LENGTH_SHORT).show();
                }}else
                    Toast.makeText(RegisterActivity.this, "PLZ FILL ALL THE DETAILS", Toast.LENGTH_SHORT).show();
                }
        });

        btnCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                startActivity(new Intent(RegisterActivity.this, MainActivity.class));
            }
        });


    }

    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {

    }

    @Override
    public void onNothingSelected(AdapterView<?> parent) {

    }
}
