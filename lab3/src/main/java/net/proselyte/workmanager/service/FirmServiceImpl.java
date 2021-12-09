package net.proselyte.workmanager.service;

import net.proselyte.workmanager.dao.FirmDao;
import net.proselyte.workmanager.model.Firm;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
public class FirmServiceImpl implements FirmService {
    private FirmDao firmDao;

    public void setFirmDao(FirmDao firmDao) {
        this.firmDao = firmDao;
    }

    @Override
    @Transactional
    public void addFirm(Firm firm) {
        this.firmDao.addFirm(firm);
    }

    @Override
    @Transactional
    public void updateFirm(Firm firm) {
        this.firmDao.updateFirm(firm);
    }

    @Override
    @Transactional
    public void removeFirm(int idFirm) {
        this.firmDao.removeFirm(idFirm);
    }

    @Override
    @Transactional
    public Firm getFirmById(int idFirm) {
        return this.firmDao.getFirmById(idFirm);
    }

    @Override
    @Transactional
    public List<Firm> listFirms() {
        return this.firmDao.listFirms();
    }
}
