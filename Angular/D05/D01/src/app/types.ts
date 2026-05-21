export interface ToDo {
  id:string,
title:string ,
description:string ,
priority:string ,
date:string ,
tags:string,
isSDone:boolean,
userEmail:string
}

export  interface User  {
   username: string,
    email: string,
    password: string,
    id: string
}
export type FilterType = 'all' | 'done' | 'notDone';

export type ToastType = 'success' | 'delete' | 'update' | 'done'|'nothing';
