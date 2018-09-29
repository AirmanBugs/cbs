import { Component, OnInit } from '@angular/core';
import { Admin } from '../../domain/admin';
import { StaffUserService } from '../../services/staff-user.service';

export const ADMIN_PATH = 'admin';

@Component({
  selector: 'cbs-user-form-admin',
  templateUrl: './user-form-admin.component.html',
  styleUrls: ['./user-form-admin.component.scss']
})
export class UserFormAdminComponent {

  user: Admin = new Admin({});
  public errorMsg = 'Something went wrong, try again later';
  public successMsg = 'User added';
  public success = false;
  public error = false;

  constructor(private staffUserService: StaffUserService) {
  }

  submit() {
    this.staffUserService.saveUser(this.user).subscribe(
      data => {
        this.success = true;
        console.log(data);
      },
      error => {
        this.error = true;
        console.error(error)
      })
  }
}
