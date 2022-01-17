package edu.ap.app;

import javafx.application.Application;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.GridPane;
import javafx.scene.text.Text;
import javafx.stage.Stage;

public class SubscribeForm extends Application {
    @Override
    public void start(Stage stage) throws Exception {
        Scene subscriptionFormScene = getSubscriptionFormScene();
        stage.setTitle("SubscriptionForm");
        stage.setScene(subscriptionFormScene);

        stage.show();
    }

    private Scene getSubscriptionFormScene(){
        Text firstNameLabel = new Text("First name");
        TextField firstNameText = new TextField();

        Text lastNameLabel = new Text("Last name");
        TextField lastNameText = new TextField();

        Text bDayLabel = new Text("Birthday");
        DatePicker datePicker = new DatePicker();

        Text genderLabel = new Text("Gender");
        ToggleGroup groupGender = new ToggleGroup();
        RadioButton maleRadio = new RadioButton("male");
        RadioButton femaleRadio = new RadioButton("female");
        maleRadio.setToggleGroup(groupGender);
        femaleRadio.setToggleGroup(groupGender);

        Text averagePagesLabel = new Text("Average pages / day");
        TextField averagePagesText = new TextField();

        Text tierLabel = new Text("Subscription tier");
        ChoiceBox tierChoiceBox = new ChoiceBox();
        tierChoiceBox.getItems().addAll("Bronze", "Silver", "Gold");

        Text genreLabel = new Text("Preffered genres");
        ObservableList<String> genres = FXCollections.observableArrayList("Triller", "Romance", "Horror", "Comedy");
        ListView<String> genreListView = new ListView<>(genres);

        Text priceLabel = new Text("Price");
        TextField priceText = new TextField();

        GridPane gridPane = new GridPane();
        gridPane.setMinSize(500, 500);
        gridPane.setPadding(new Insets(10, 10, 10, 10));

        gridPane.setVgap(50);
        gridPane.setHgap(50);
        gridPane.setAlignment(Pos.CENTER);

        gridPane.add(firstNameLabel, 0, 0);
        gridPane.add(firstNameText, 1, 0);
        gridPane.add(lastNameLabel, 0, 1);
        gridPane.add(lastNameText, 1, 1);
        gridPane.add(bDayLabel, 0, 2);
        gridPane.add(datePicker, 1, 2);
        gridPane.add(genderLabel, 0, 3);
        gridPane.add(maleRadio, 1, 3);
        gridPane.add(femaleRadio, 2, 3);
        gridPane.add(averagePagesLabel, 0, 4);
        gridPane.add(averagePagesText, 1, 4);
        gridPane.add(tierLabel, 0, 5);
        gridPane.add(tierChoiceBox, 1, 5);
        gridPane.add(genreLabel, 0, 6);
        gridPane.add(genreListView, 1, 6);
        gridPane.add(priceLabel, 0, 7);
        gridPane.add(priceText, 1, 7);

        firstNameLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        lastNameLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        bDayLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        genderLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        averagePagesLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        tierLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        genreLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        priceLabel.setStyle("-fx-font: normal bold 15px 'serif' ");

        gridPane.setStyle("-fx-background-color: BEIGE;");

        Scene scene = new Scene(gridPane);
        return scene;
    }

    public static void main(String[] args) {
        launch(args);
    }
}
