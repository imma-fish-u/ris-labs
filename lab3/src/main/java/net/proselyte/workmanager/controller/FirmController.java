package net.proselyte.workmanager.controller;

import net.proselyte.workmanager.model.Firm;
import net.proselyte.workmanager.service.FirmService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
public class FirmController {
    private FirmService firmService;

    @Autowired(required = true)
    @Qualifier(value = "firmService")
    public void setFirmService(FirmService firmService) {
        this.firmService = firmService;
    }

    @RequestMapping(value = "firms", method = RequestMethod.GET)
    public String listFirms(Model model){
        model.addAttribute("firm", new Firm());
        model.addAttribute("listFirms", this.firmService.listFirms());

        return "firms";
    }

    @RequestMapping(value = "/firms/add", method = RequestMethod.POST)
    public String addFirm(@ModelAttribute("firm") Firm firm){
        if(firm.getIdFirm() == 0){
            this.firmService.addFirm(firm);
        }else {
            this.firmService.updateFirm(firm);
        }

        return "redirect:/firms";
    }

    @RequestMapping("/remove/{idFirm}")
    public String removeFirm(@PathVariable("idFirm") int idFirm){
        this.firmService.removeFirm(idFirm);

        return "redirect:/firms";
    }

    @RequestMapping("edit/{idFirm}")
    public String editFirm(@PathVariable("idFirm") int idFirm, Model model){
        model.addAttribute("firm", this.firmService.getFirmById(idFirm));
        model.addAttribute("listFirms", this.firmService.listFirms());

        return "firms";
    }

    @RequestMapping("firmdata/{idFirm}")
    public String firmData(@PathVariable("idFirm") int idFirm, Model model){
        model.addAttribute("firm", this.firmService.getFirmById(idFirm));

        return "firmdata";
    }
}
