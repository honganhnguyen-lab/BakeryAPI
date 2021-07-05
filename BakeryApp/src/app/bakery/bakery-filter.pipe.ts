import { Pipe, PipeTransform } from "@angular/core";
import { Bakery } from "../shared/bakery.model";

@Pipe({
  name: 'serviceFilter'
})
export class BakeryFilterPipe implements PipeTransform{
  transform(lists : Bakery[],bakeryName: string) : Bakery[]{
    if(!lists || !bakeryName){
      return lists;
    }
    return lists.filter(lists=>
      lists.bakeryName.toLocaleLowerCase().indexOf(bakeryName.toLowerCase()) !== -1);
  }
}
