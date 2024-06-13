import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routes: RoutesService) {
  return () => {
    routes.add([
      {
        path: '/chatgpt',
        name: '::Menu:ChatGpt',
        iconClass: 'fas  fa-comment',
        order: 3,
        layout: eLayoutType.application,
        requiredPolicy: 'Sai.Dashboard.Host  || Sai.Dashboard.Tenant',
      },
    ]);
  };
}
