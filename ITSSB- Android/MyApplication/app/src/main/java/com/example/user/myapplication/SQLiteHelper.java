package com.example.user.myapplication;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.database.sqlite.SQLiteStatement;
import android.util.Log;
import android.widget.Toast;

public class SQLiteHelper extends SQLiteOpenHelper {

    SQLiteDatabase db;

    public SQLiteHelper(Context context, String name, SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    public void createTable(String sql){
        db = getWritableDatabase();
        db.execSQL(sql);
    }

    //insert
    public void insertTable(String email, String pwd, String fName, String lName, String gender){
        db = getWritableDatabase();
        String sql = "insert into register values(null,?,?,?,?,?)";
        SQLiteStatement st = db.compileStatement(sql);
        st.clearBindings();
        st.bindString(1, email);
        st.bindString(2, pwd);
        st.bindString(3, fName);
        st.bindString(4, lName);
        st.bindString(5, gender);

        st.executeInsert();
        db.close();
    }

    //retrieve
    public Cursor login(String email, String pwd){
        db = getWritableDatabase();
        String sql = "select * from register where email = ? and  pwd = ?";
//        SQLiteStatement st = db.compileStatement(sql);
//        st.clearBindings();
//        st.bindString(1, email);
//        st.bindString(2, pwd);
//
//        st.simpleQueryForString();
        String[] arg = {email, pwd};

        Cursor res = db.rawQuery(sql, arg);
        return res;
    }


}
