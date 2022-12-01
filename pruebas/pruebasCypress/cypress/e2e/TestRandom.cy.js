describe('Prueba', () => {
    it('Prueba general', () => {
        let arrayPalos=['CORAZON','TREBOL','ESPADA','COCO']
        cy.visit(Cypress.env('base_url'))
        for (let index = 1; index < 4; index++) {
            cy.visit(Cypress.env('base_url'))

            cy.get('select[name="carta1Palo"]').select(arrayPalos[parseInt(getNumero(0, 4))])
            cy.get('input[name="carta1"]').type(parseInt(getNumero(1, 13)))
            
            cy.get('select[name="carta2Palo"]').select(arrayPalos[parseInt(getNumero(0, 4))])
            cy.get('input[name="carta2"]').type(parseInt(getNumero(1, 13)))
            
            cy.get('select[name="carta3Palo"]').select(arrayPalos[parseInt(getNumero(0, 4))])
            cy.get('input[name="carta3"]').type(parseInt(getNumero(1, 13)))
            
            cy.get('select[name="carta4Palo"]').select(arrayPalos[parseInt(getNumero(0, 4))])
            cy.get('input[name="carta4"]').type(parseInt(getNumero(1, 13)))
            
            cy.get('select[name="carta5Palo"]').select(arrayPalos[parseInt(getNumero(0, 4))])
            cy.get('input[name="carta5"]').type(parseInt(getNumero(1, 13)))
            
            cy.get('button[class="btn btn-primary"]').click()   

            
        }    
        
    })
  
  })
  //Tomar 
  function getNumero(min, max) {
    return Math.random() * (max - min) + min;
  }