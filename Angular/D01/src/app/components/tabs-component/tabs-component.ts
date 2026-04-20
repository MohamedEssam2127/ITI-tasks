import { Component ,EventEmitter,Output } from '@angular/core';
import { FilterType } from '../../types';

@Component({
  selector: 'app-tabs',
  imports: [],
  templateUrl: './tabs-component.html',
  styleUrl: './tabs-component.css',
})
export class TabsComponent {
@Output() filterChanged = new EventEmitter<FilterType>();
  activeTab: FilterType = 'all';
  
  selectTab(tab: FilterType) {
    this.activeTab = tab;
    this.filterChanged.emit(tab);
  }
}
