package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;
import android.view.View;

import java.text.Collator;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);


        setContentView(R.layout.activity_main);
    }

    public void onClick(View view, Collator asd) {
        EditText editText = findViewById(R.id.editTextTextPersonName );
        asd.getInstance().data = editText.getText().toString();
                Intent intent = new Invent ( packageContextb : this, ppp.class);
                startActivity(intent);
    }


    }


}


