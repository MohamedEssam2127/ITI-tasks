// prototype 
class Document {
  constructor(header, footer, pages, text) {
    this.header = header;
    this.footer = footer;
    this.pages = pages;
    this.text = text;
  }

  clone() {
    return new Document(
        this.header,
         this.footer,
          this.pages,
           this.text);
  }
  display() {
    console.log(`header: ${this.header}`);
    console.log(`footer: ${this.footer}`);
    console.log(`pages: ${this.pages}`);
    console.log(`txt: ${this.text}`);
    console.log("----------------------");
  }
}

const originalDoc = new Document(" H1", " F1", 10, " Content");

const invoiceDoc = originalDoc.clone();

originalDoc.display();
invoiceDoc.display();