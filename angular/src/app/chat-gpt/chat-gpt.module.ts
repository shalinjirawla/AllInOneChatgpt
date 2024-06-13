import { PageModule } from '@abp/ng.components/page';
import { SaasModule } from '@volo/abp.ng.saas';
import { SharedModule } from '../shared/shared.module';
import { ChatGPTComponent } from './chat-gpt.component';
import { ChatGPTRoutingModule } from './chat-gpt-routing.module';
import { NgModule } from '@angular/core';
import {MatTabsModule} from '@angular/material/tabs';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [ChatGPTComponent],
  imports: [
    SharedModule,
    ChatGPTRoutingModule,
    SaasModule,
    PageModule,
    MatTabsModule,
    ReactiveFormsModule,
    FormsModule,
  ],
})
export class ChatGPTModule {}
