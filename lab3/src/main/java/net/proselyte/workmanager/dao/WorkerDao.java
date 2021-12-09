package net.proselyte.workmanager.dao;

import net.proselyte.workmanager.model.Worker;

import java.util.List;

public interface WorkerDao {
    public void addWorker(Worker worker);

    public void updateWorker(Worker worker);

    public void removeWorker(int idWorker);

    public Worker getWorkerById(int idWorker);

    public List<Worker> listWorkers();
}
