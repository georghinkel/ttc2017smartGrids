/**
 */
package substationStandard.Dataclasses;

import org.eclipse.emf.ecore.EObject;

import substationStandard.Enumerations.ControlOutputKind;

/**
 * <!-- begin-user-doc -->
 * A representation of the model object '<em><b>Control Output</b></em>'.
 * <!-- end-user-doc -->
 *
 * <p>
 * The following features are supported:
 * </p>
 * <ul>
 *   <li>{@link substationStandard.Dataclasses.ControlOutput#getVal <em>Val</em>}</li>
 * </ul>
 *
 * @see substationStandard.Dataclasses.DataclassesPackage#getControlOutput()
 * @model
 * @generated
 */
public interface ControlOutput extends EObject {
	/**
	 * Returns the value of the '<em><b>Val</b></em>' attribute.
	 * The literals are from the enumeration {@link substationStandard.Enumerations.ControlOutputKind}.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of the '<em>Val</em>' attribute isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @return the value of the '<em>Val</em>' attribute.
	 * @see substationStandard.Enumerations.ControlOutputKind
	 * @see #setVal(ControlOutputKind)
	 * @see substationStandard.Dataclasses.DataclassesPackage#getControlOutput_Val()
	 * @model
	 * @generated
	 */
	ControlOutputKind getVal();

	/**
	 * Sets the value of the '{@link substationStandard.Dataclasses.ControlOutput#getVal <em>Val</em>}' attribute.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the new value of the '<em>Val</em>' attribute.
	 * @see substationStandard.Enumerations.ControlOutputKind
	 * @see #getVal()
	 * @generated
	 */
	void setVal(ControlOutputKind value);

} // ControlOutput
