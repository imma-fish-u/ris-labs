package controller;

import entity.Firm;
import entity.Worker;
import model.Model;


import javax.enterprise.context.SessionScoped;
import javax.faces.bean.ManagedBean;
import java.io.Serializable;
import java.util.List;

@ManagedBean(name = "newMB")
@SessionScoped
public class NewJSFManagedBean implements Serializable {

    private Model model = new Model();
    private List<Worker> workers;
    private List<Firm> firms;
    private String lastname;
    private String name;

    private Firm firm = new Firm();
    private Worker worker = new Worker();

    public NewJSFManagedBean() {
    }

    public Firm getFirm() {
        return firm;
    }

    public void setFirm(Firm firm) {
        this.firm = firm;
    }

    public List<Firm> getFirms() {
        return firms;
    }

    public void setFirms(List<Firm> firms) {
        this.firms = firms;
    }

    public List<Worker> getWorkers() {
        return workers;
    }

    public Worker getWorker() {
        return worker;
    }

    public void setWorker(Worker worker) {
        this.worker = worker;
    }

    public void setWorkers(List<Worker> workers) {
        this.workers = workers;
    }

    public String getLastname() {
        return lastname;
    }

    public void setLastname(String lastname) {
        this.lastname = lastname;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String moveToWorkers() {
       workers = model.getAllWorkers();
        System.out.println("Size: " + workers.size());
        return "workers";
    }

    public String moveToFirms() {
        firms = model.getAllFirms();
        System.out.println("Size: " + firms.size());
        return "firms";
    }

    public String moveToSearchWorkers() {
       workers = model.findWorkers(name, lastname);
        return "workers";
    }

    public void deleteFirm() {
        model.deleteFirm(firm);
    }

    public void addFirm() {
        model.addFirm(firm);
    }

    public void addWorker() {
        model.addWorker(worker);
    }
}
