describe('Prueba', () => {
      it('Test1', () => {
        cy.visit(Cypress.env('base_url'))

        cy.get('select[name="carta1Palo"]').select('ESPADA')
        cy.get('input[name="carta1"]').type('1')
        
        cy.get('select[name="carta2Palo"]').select('ESPADA')
        cy.get('input[name="carta2"]').type('13')
        
        cy.get('select[name="carta3Palo"]').select('ESPADA')
        cy.get('input[name="carta3"]').type('12')
        
        cy.get('select[name="carta4Palo"]').select('ESPADA')
        cy.get('input[name="carta4"]').type('11')
        
        cy.get('select[name="carta5Palo"]').select('ESPADA')
        cy.get('input[name="carta5"]').type('10')
        
        cy.get('button[class="btn btn-primary"]').click()    
        cy.get('#respuesta').should('contain', 'COLOR')
         
        
    }),
    it('Test2', () => {
      cy.visit(Cypress.env('base_url'))

      cy.get('select[name="carta1Palo"]').select('CORAZON')
      cy.get('input[name="carta1"]').type('10')
      
      cy.get('select[name="carta2Palo"]').select('CORAZON')
      cy.get('input[name="carta2"]').type('9')
      
      cy.get('select[name="carta3Palo"]').select('CORAZON')
      cy.get('input[name="carta3"]').type('8')
      
      cy.get('select[name="carta4Palo"]').select('CORAZON')
      cy.get('input[name="carta4"]').type('7')
      
      cy.get('select[name="carta5Palo"]').select('CORAZON')
      cy.get('input[name="carta5"]').type('6')
      
      cy.get('button[class="btn btn-primary"]').click()    
      cy.get('#respuesta').should('contain', 'COLOR') 
      
  }),
  it('Test3', () => {
    cy.visit(Cypress.env('base_url'))

    cy.get('select[name="carta1Palo"]').select('CORAZON')
    cy.get('input[name="carta1"]').type('12')
    
    cy.get('select[name="carta2Palo"]').select('TREBOL')
    cy.get('input[name="carta2"]').type('12')
    
    cy.get('select[name="carta3Palo"]').select('ESPADA')
    cy.get('input[name="carta3"]').type('12')
    
    cy.get('select[name="carta4Palo"]').select('COCO')
    cy.get('input[name="carta4"]').type('12')
    
    cy.get('select[name="carta5Palo"]').select('COCO')
    cy.get('input[name="carta5"]').type('10')
    
    cy.get('button[class="btn btn-primary"]').click() 
    cy.get('#respuesta').should('contain', 'POKER')    
  })

  it('Test4', () => {
  cy.visit(Cypress.env('base_url'))

  cy.get('select[name="carta1Palo"]').select('COCO')
  cy.get('input[name="carta1"]').type('1')
  
  cy.get('select[name="carta2Palo"]').select('ESPADA')
  cy.get('input[name="carta2"]').type('1')
  
  cy.get('select[name="carta3Palo"]').select('CORAZON')
  cy.get('input[name="carta3"]').type('1')
  
  cy.get('select[name="carta4Palo"]').select('TREBOL')
  cy.get('input[name="carta4"]').type('7')
  
  cy.get('select[name="carta5Palo"]').select('COCO')
  cy.get('input[name="carta5"]').type('7')
  
  cy.get('button[class="btn btn-primary"]').click()   
  cy.get('#respuesta').should('contain', 'FULL')  
  
}),
it('Test5', () => {
  cy.visit(Cypress.env('base_url'))

  cy.get('select[name="carta1Palo"]').select('COCO')
  cy.get('input[name="carta1"]').type('1')
  
  cy.get('select[name="carta2Palo"]').select('COCO')
  cy.get('input[name="carta2"]').type('11')
  
  cy.get('select[name="carta3Palo"]').select('COCO')
  cy.get('input[name="carta3"]').type('8')
  
  cy.get('select[name="carta4Palo"]').select('COCO')
  cy.get('input[name="carta4"]').type('5')
  
  cy.get('select[name="carta5Palo"]').select('COCO')
  cy.get('input[name="carta5"]').type('7')
  
  cy.get('button[class="btn btn-primary"]').click()     
  cy.get('#respuesta').should('contain', 'COLOR')
  
})
})