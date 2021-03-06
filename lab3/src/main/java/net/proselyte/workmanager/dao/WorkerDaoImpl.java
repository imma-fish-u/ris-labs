package net.proselyte.workmanager.dao;

import net.proselyte.workmanager.model.Worker;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class WorkerDaoImpl implements WorkerDao {
    private static final Logger logger = LoggerFactory.getLogger(WorkerDaoImpl.class);

    private SessionFactory sessionFactory;

    public void setSessionFactory(SessionFactory sessionFactory) {
        this.sessionFactory = sessionFactory;
    }

    @Override
    public void addWorker(Worker worker) {
        Session session = this.sessionFactory.getCurrentSession();
        session.persist(worker);
        logger.info("Worker successfully saved. Worker details: " + worker);
    }

    @Override
    public void updateWorker(Worker worker) {
        Session session = this.sessionFactory.getCurrentSession();
        session.update(worker);
        logger.info("Worker successfully update. Worker details: " + worker);
    }

    @Override
    public void removeWorker(int idWorker) {
        Session session = this.sessionFactory.getCurrentSession();
        Worker worker = (Worker) session.load(Worker.class, new Integer(idWorker));

        if(worker !=null){
            session.delete(worker);
        }
        logger.info("Worker successfully removed. Worker details: " + worker);
    }

    @Override
    public Worker getWorkerById(int idWorker) {
        Session session =this.sessionFactory.getCurrentSession();
        Worker worker = (Worker) session.load(Worker.class, new Integer(idWorker));
        logger.info("Worker successfully loaded. Worker details: " + worker);

        return worker;
    }

    @Override
    public List<Worker> listWorkers() {
        Session session = this.sessionFactory.getCurrentSession();
        List<Worker> workerList = session.createQuery("from Worker").list();

        for(Worker worker : workerList){
            logger.info("Worker list: " + worker);
        }

        return workerList;
    }
}
