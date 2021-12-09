package net.proselyte.workmanager.controller;

import net.proselyte.workmanager.model.Worker;
import net.proselyte.workmanager.service.WorkerService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
public class WorkerController {
    private WorkerService workerService;

    @Autowired(required = true)
    @Qualifier(value = "workerService")
    public void setWorkerService(WorkerService workerService) {
        this.workerService = workerService;
    }

    @RequestMapping(value = "workers", method = RequestMethod.GET)
    public String listWorkers(Model model){
        model.addAttribute("worker", new Worker());
        model.addAttribute("listWorkers", this.workerService.listWorkers());

        return "workers";
    }

    @RequestMapping(value = "/workers/add", method = RequestMethod.POST)
    public String addWorker(@ModelAttribute("worker") Worker worker){
        if(worker.getIdWorker() == 0){
            this.workerService.addWorker(worker);
        }else {
            this.workerService.updateWorker(worker);
        }

        return "redirect:/workers";
    }

    @RequestMapping("/remove/{idWorker}")
    public String removeWorker(@PathVariable("idWorker") int idWorker){
        this.workerService.removeWorker(idWorker);

        return "redirect:/workers";
    }

    @RequestMapping("edit/{idWorker}")
    public String editWorker(@PathVariable("idWorker") int idWorker, Model model){
        model.addAttribute("worker", this.workerService.getWorkerById(idWorker));
        model.addAttribute("listWorkers", this.workerService.listWorkers());

        return "workers";
    }

    @RequestMapping("workerdata/{idWorker}")
    public String workerData(@PathVariable("idWorker") int idWorker, Model model){
        model.addAttribute("worker", this.workerService.getWorkerById(idWorker));

        return "workerdata";
    }
}
