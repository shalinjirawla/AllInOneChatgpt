import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChatGPTComponent } from './chat-gpt.component';

const routes: Routes = [{ path: '', component: ChatGPTComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ChatGPTRoutingModule {}