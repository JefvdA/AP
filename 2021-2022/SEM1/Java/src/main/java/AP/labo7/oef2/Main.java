package AP.labo7.oef2;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Main {
    public static void main(String[] args) {
        Listener();
    }

    public static void Listener()
    {
        JButton testButton = new JButton("Test Button");
        testButton.addActionListener((e) -> {
            System.out.println("Clicked anonymous class definition");
        });

        JFrame frame = new JFrame("Listener Test");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.add(testButton, BorderLayout.CENTER);
        frame.pack();
        frame.setVisible(true);
    }
}
