package com.company;

public class Car implements Vehicle {

    private String make;
    private String model;
    private int milesTraveled;

    public Car(){};

    public Car(String make, String model, int milesTraveled) {
        this.make = make;
        this.model = model;
        this.milesTraveled = milesTraveled;
    }

    public String getMake() {
        return make;
    }

    public void setMake(String make) {
        this.make = make;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public int getMilesTraveled() {
        return milesTraveled;
    }

    public void setMilesTraveled(int milesTraveled) {
        this.milesTraveled = milesTraveled;
    }

    @Override
    public void drive(int miles) {

    }

    @Override
    public void displayMilesTraveled() {

    }
}
