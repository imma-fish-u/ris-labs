package net.proselyte.workmanager.dao;

import net.proselyte.workmanager.model.Firm;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class FirmDaoImpl implements FirmDao {
    private static final Logger logger = LoggerFactory.getLogger(FirmDaoImpl.class);

    private SessionFactory sessionFactory;

    public void setSessionFactory(SessionFactory sessionFactory) {
        this.sessionFactory = sessionFactory;
    }

    @Override
    public void addFirm(Firm firm) {
        Session session = this.sessionFactory.getCurrentSession();
        session.persist(firm);
        logger.info("Firm successfully saved. Firm details: " + firm);
    }

    @Override
    public void updateFirm(Firm firm) {
        Session session = this.sessionFactory.getCurrentSession();
        session.update(firm);
        logger.info("Firm successfully update. Firm details: " + firm);
    }

    @Override
    public void removeFirm(int idFirm) {
        Session session = this.sessionFactory.getCurrentSession();
        Firm firm = (Firm) session.load(Firm.class, new Integer(idFirm));

        if(firm !=null){
            session.delete(firm);
        }
        logger.info("Firm successfully removed. Firm details: " + firm);
    }

    @Override
    public Firm getFirmById(int idFirm) {
        Session session =this.sessionFactory.getCurrentSession();
        Firm firm = (Firm) session.load(Firm.class, new Integer(idFirm));
        logger.info("Firm successfully loaded. Firm details: " + firm);

        return firm;
    }

    @Override
    public List<Firm> listFirms() {
        Session session = this.sessionFactory.getCurrentSession();
        List<Firm> firmList = session.createQuery("from Firm").list();

        for(Firm firm : firmList){
            logger.info("Firm list: " + firm);
        }

        return firmList;
    }
}
