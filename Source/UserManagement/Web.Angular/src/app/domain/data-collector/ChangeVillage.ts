import { Command } from '../../services/Command';

export class ChangeVillage extends Command {
    dataCollectorId: string;
    village: string;
    constructor() {
        super();
        this.type = 'CBS#UserManagement.DataCollector.Changing-ChangeVillage+Command@1';
    }
}
