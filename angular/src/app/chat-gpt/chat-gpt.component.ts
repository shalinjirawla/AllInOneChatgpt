import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { PromptMasterDto, PromptMasterService } from '@proxy/prompt-masters';
import { ToasterService } from '@abp/ng.theme.shared';
import { HistoryDto, HistoryService } from '@proxy/chat-history';
import { AppConsts } from '../shared/AppConsts';

@Component({
  selector: 'app-chat-gpt',
  templateUrl: './chat-gpt.component.html',
  styleUrls: ['./chat-gpt.component.scss'],
})
export class ChatGPTComponent implements OnInit {
  isModalOpen = false;
  isHistory = false
  isCreateNewPrompt = false;
  searchInput = '';
  savedPrompt: PromptMasterDto[] = [];
  promptTitle: string = '';
  promptContent: string = '';
  form: FormGroup;
  chatHistory : HistoryDto[] =[]
  communityPromptList: PromptMasterDto[];
  userMessage: string = null;
  constructor(private fb: FormBuilder,
    private promptMasterService: PromptMasterService,
    private toasterService: ToasterService,
    private historyService : HistoryService) {
  }

  ngOnInit() {
    
    this.buildForm();
    this.getdata();
  }

  buildForm() {
    this.form = this.fb.group({
      id: [null],
      title: [null],
      content: [null],
    });
  }

  getdata() {
    this.promptMasterService.getAll().subscribe(result => {
      
      this.communityPromptList = result;
    });
  }

  onUse(value: string) {
    this.searchInput = value;
    this.isModalOpen = false;
  }

  savePrompt(value: PromptMasterDto) {
    this.savedPrompt.push(value);
    sessionStorage.setItem('SavePrompt', JSON.stringify(this.savedPrompt));
    JSON.parse(sessionStorage.getItem('SavePrompt'));
  }

  editPrompt(id: string) {
    this.isCreateNewPrompt = true;
    this.promptMasterService.getById(id).subscribe(res => {
      this.form.patchValue(res);
      this.getdata();
    })
  }

  createNewPrompt() {
    this.promptMasterService.createOrUpdate(this.form.value).subscribe(res => {
      this.isModalOpen = false
      this.form.reset();
      this.toasterService.success('Added Successfully', '', {
        life: 5000,
      });
      this.getdata();
      this.isCreateNewPrompt= false
    });
  }

  clear(){
    let html=document.querySelector(".containers");
    if(html)
    {html.innerHTML="";}
  }

  send(chatElement) {
    const messageElement = chatElement.querySelector("p")
    const requestOptions = {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        "Authorization": `Bearer ${AppConsts.API_Key}`
      },
      body: JSON.stringify({
        model: "text-davinci-003",
        prompt: this.userMessage,
        max_tokens: 4000,
        temperature: 0.5
      })
    }

    fetch(AppConsts.API_URL, requestOptions).then(res => res.json()).then(data => {
      messageElement.textContent = data.choices[0].text.trim();
      this.chathistory(messageElement.textContent,false);
    }).catch(() => {
    })
  }

  createChatLi = (message, className) => {
    const chatLi = document.createElement("div");
    chatLi.classList.add("chat", `${className}`);
    let chatContent = className === "outgoing" ? `<p class="message-content"></p>` : `<p></p>`;
    chatLi.innerHTML = chatContent;
    chatLi.querySelector("p").textContent = message;
    return chatLi; 
  }

  handleChat = () => {
    const chatInput = document.querySelector(".chat-input textarea") as HTMLInputElement | null;
    const chatbox = document.querySelector(".containers");
    const inputInitHeight = chatInput.scrollHeight;
    this.userMessage = this.searchInput.trim(); 
    if (!this.userMessage) return;
    chatInput.value = "";
    chatInput.style.height = `${inputInitHeight}px`;
    chatbox.appendChild(this.createChatLi(this.userMessage, "outgoing"));
    chatbox.scrollTo(0, chatbox.scrollHeight);
    this.chathistory(this.userMessage,true);

    setTimeout(() => {
      const incomingChatLi = this.createChatLi("Thinking...", "incoming");
      chatbox.appendChild(incomingChatLi);
      chatbox.scrollTo(0, chatbox.scrollHeight);
      this.send(incomingChatLi);
    }, 600);
  }

  chathistory(value,isUser){
    let obj={
      text:value.trim(),
      isUser:isUser,
    }
    this.historyService.createOrUpdate(obj).subscribe(res => {
    })
  }
}