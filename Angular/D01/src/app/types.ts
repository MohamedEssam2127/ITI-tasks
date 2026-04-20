export interface ToDo {
  id:string,
title:string ,
description:string ,
priority:string ,
date:string ,
tags:string,
isSDone:boolean
}

export type FilterType = 'all' | 'done' | 'notDone';

export type ToastType = 'success' | 'delete' | 'update' | 'done'|'nothing';
