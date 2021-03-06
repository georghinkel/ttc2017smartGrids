/**
 */
package CIM.IEC61970.Domain;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

import org.eclipse.emf.common.util.Enumerator;

/**
 * <!-- begin-user-doc -->
 * A representation of the literals of the enumeration '<em><b>Monetary Amount Per Heat Unit</b></em>',
 * and utility methods for working with them.
 * <!-- end-user-doc -->
 * @see CIM.IEC61970.Domain.DomainPackage#getMonetaryAmountPerHeatUnit()
 * @model
 * @generated
 */
public enum MonetaryAmountPerHeatUnit implements Enumerator {
	/**
	 * The '<em><b>USD per J</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #USD_PER_J_VALUE
	 * @generated
	 * @ordered
	 */
	USD_PER_J(0, "USD_per_J", "USD_per_J"),

	/**
	 * The '<em><b>EUR per J</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #EUR_PER_J_VALUE
	 * @generated
	 * @ordered
	 */
	EUR_PER_J(1, "EUR_per_J", "EUR_per_J");

	/**
	 * The '<em><b>USD per J</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>USD per J</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #USD_PER_J
	 * @model name="USD_per_J"
	 * @generated
	 * @ordered
	 */
	public static final int USD_PER_J_VALUE = 0;

	/**
	 * The '<em><b>EUR per J</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>EUR per J</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #EUR_PER_J
	 * @model name="EUR_per_J"
	 * @generated
	 * @ordered
	 */
	public static final int EUR_PER_J_VALUE = 1;

	/**
	 * An array of all the '<em><b>Monetary Amount Per Heat Unit</b></em>' enumerators.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private static final MonetaryAmountPerHeatUnit[] VALUES_ARRAY =
		new MonetaryAmountPerHeatUnit[] {
			USD_PER_J,
			EUR_PER_J,
		};

	/**
	 * A public read-only list of all the '<em><b>Monetary Amount Per Heat Unit</b></em>' enumerators.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public static final List<MonetaryAmountPerHeatUnit> VALUES = Collections.unmodifiableList(Arrays.asList(VALUES_ARRAY));

	/**
	 * Returns the '<em><b>Monetary Amount Per Heat Unit</b></em>' literal with the specified literal value.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param literal the literal.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static MonetaryAmountPerHeatUnit get(String literal) {
		for (int i = 0; i < VALUES_ARRAY.length; ++i) {
			MonetaryAmountPerHeatUnit result = VALUES_ARRAY[i];
			if (result.toString().equals(literal)) {
				return result;
			}
		}
		return null;
	}

	/**
	 * Returns the '<em><b>Monetary Amount Per Heat Unit</b></em>' literal with the specified name.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param name the name.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static MonetaryAmountPerHeatUnit getByName(String name) {
		for (int i = 0; i < VALUES_ARRAY.length; ++i) {
			MonetaryAmountPerHeatUnit result = VALUES_ARRAY[i];
			if (result.getName().equals(name)) {
				return result;
			}
		}
		return null;
	}

	/**
	 * Returns the '<em><b>Monetary Amount Per Heat Unit</b></em>' literal with the specified integer value.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the integer value.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static MonetaryAmountPerHeatUnit get(int value) {
		switch (value) {
			case USD_PER_J_VALUE: return USD_PER_J;
			case EUR_PER_J_VALUE: return EUR_PER_J;
		}
		return null;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final int value;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final String name;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final String literal;

	/**
	 * Only this class can construct instances.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private MonetaryAmountPerHeatUnit(int value, String name, String literal) {
		this.value = value;
		this.name = name;
		this.literal = literal;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public int getValue() {
	  return value;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public String getName() {
	  return name;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public String getLiteral() {
	  return literal;
	}

	/**
	 * Returns the literal value of the enumerator, which is its string representation.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public String toString() {
		return literal;
	}
	
} //MonetaryAmountPerHeatUnit
