package net.proselyte.workmanager.service;

import net.proselyte.workmanager.dao.WorkerDao;
import net.proselyte.workmanager.model.Worker;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
public class WorkerServiceImpl implements WorkerService {
    private WorkerDao workerDao;

    public void setWorkerDao(WorkerDao workerDao) {
        this.workerDao = workerDao;
    }

    @Override
    @Transactional
    public void addWorker(Worker worker) {
        this.workerDao.addWorker(worker);
    }

    @Override
    @Transactional
    public void updateWorker(Worker worker) {
        this.workerDao.updateWorker(worker);
    }

    @Override
    @Transactional
    public void removeWorker(int idWorker) {
        this.workerDao.removeWorker(idWorker);
    }

    @Override
    @Transactional
    public Worker getWorkerById(int idWorker) {
        return this.workerDao.getWorkerById(idWorker);
    }

    @Override
    @Transactional
    public List<Worker> listWorkers() {
        return this.workerDao.listWorkers();
    }
}
